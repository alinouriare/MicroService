using Core.Entities;
using RabbitMQ.Client;
using RabbitMQ.Client.Events;
using System;
using Tools;

namespace WorkerConsumer
{
    class Program
    {
        public static IConnectionFactory _connectionFactory;
        public static IConnection _connection;
        public static IModel _model;
        public const string QueueName = "TestQueue";

        static void Main(string[] args)
        {
            CreateConnection();
            var counsumer = new EventingBasicConsumer(_model);
            counsumer.Received += (model, ea) =>
             {
                 var body = ea.Body.ToArray();
                 var paymnet = body.FromByteArray<Payment>();
                 Console.WriteLine($"[x] Received{paymnet.FirstName} {paymnet.LastName} {paymnet.Value}");
             };
            _model.BasicConsume(queue: QueueName, autoAck: true, consumer: counsumer);
            Console.WriteLine("press [enter] to exit");
            Console.ReadLine();
        }

        public static void CreateConnection()
        {
            _connectionFactory = new ConnectionFactory
            {
                HostName = "localhost",
                UserName = "guest",
                Password = "guest",
                Port = Protocols.DefaultProtocol.DefaultPort
            };
            _connection = _connectionFactory.CreateConnection();
            _model = _connection.CreateModel();
            _model.QueueDeclare(QueueName, true, false, false, null);
        }
    }
}

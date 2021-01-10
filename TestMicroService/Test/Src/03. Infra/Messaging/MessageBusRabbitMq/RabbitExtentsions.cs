﻿using RabbitMQ.Client.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utilitie.Services.MessageBus;

namespace MessageBusRabbitMq
{
    static class RabbitExtentsions
    {
        public static Parcel ToParcel(this BasicDeliverEventArgs basicDeliverEventArgs)
        {
            Parcel parcel = new Parcel
            {
                CorrelationId = basicDeliverEventArgs?.BasicProperties?.CorrelationId,
                MessageId = basicDeliverEventArgs?.BasicProperties.MessageId,
                Route = basicDeliverEventArgs.RoutingKey,
                MessageBody = Encoding.UTF8.GetString(basicDeliverEventArgs.Body.ToArray()),
                MessageName = basicDeliverEventArgs.BasicProperties.Type,
                Headers = basicDeliverEventArgs?.BasicProperties?.Headers != null ? (Dictionary<string, object>)basicDeliverEventArgs?.BasicProperties?.Headers : null
            };
            return parcel;
        }
    }
}

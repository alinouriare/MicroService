using ConsumerDtoes;
using Newtonsoft.Json;
using System;

namespace ConsumerConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string url = "http://localhost:28597";
            Console.WriteLine("please send a person id: ");
            string id = Console.ReadLine();
            var result = APICaller.Call(url, id).Result.Content.ReadAsStringAsync().Result;
            PersonResponseDto dto = JsonConvert.DeserializeObject<PersonResponseDto>(result);
            Console.WriteLine($"First Name: {dto.FirstName}, Last Name: {dto.LastName}");
            Console.ReadKey();
        }
    }
}

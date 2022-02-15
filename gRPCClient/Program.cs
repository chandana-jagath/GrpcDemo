using System;
using System.Threading.Tasks;
using Grpc.Net.Client;
using GrpcService;

namespace gRPCClient
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var input = new CustomerLockupModel { UserId = 5 };
            var channel = GrpcChannel.ForAddress("https://localhost:5001");
            var client = new Customer.CustomerClient(channel);
            var reply = await client.GetCustomerInfoAsync(input);
            Console.WriteLine($"{reply.FirstName} {reply.LastName} {reply.Age}");
            Console.ReadLine();
        }
    }
}

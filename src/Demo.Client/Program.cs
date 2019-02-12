using System;
using System.Runtime.InteropServices;
using Demo.Message;
using Grpc.Core;

namespace Demo.Client
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Demo Client is Ready...");
            var host = "127.0.0.1";
            var port = "9999";

            var channel = new Channel($"{host}:{port}", ChannelCredentials.Insecure);
            var serviceClient = new DemoService.DemoServiceClient(channel);

            var result1 = serviceClient.TestWithEmpty(new EmptyMsg());
            Console.WriteLine($"Calling Say and return response is {result1.Values.ToString()}");
            
            Console.WriteLine("Please type input for calling Say:");
            var msg = Console.ReadLine();
            var result2 = serviceClient.Say(new GreetingMsg { Value = msg});
            Console.WriteLine($"Calling Say and return response is {result2.MsgValue},{result2.ReturnValue}");
        }
    }
} 
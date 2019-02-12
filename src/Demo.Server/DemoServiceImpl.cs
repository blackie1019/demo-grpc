using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Demo.Message;
using Grpc.Core;

namespace Demo.Server
{
    public class DemoServiceImpl:DemoService.DemoServiceBase
    {
        public override Task<GreetingResponse> Say(GreetingMsg request, ServerCallContext context)
        {
            var response = new GreetingResponse
            {
                MsgValue = request.Value,
                ReturnValue = $"Received on {DateTime.Now:O}",
            };
            return Task.FromResult(response);
        }

        public override Task<TestResponse> TestWithEmpty(EmptyMsg request, ServerCallContext context)
        {
            var response = new TestResponse();//new List<int>();
            var randon = new Random(DateTime.Now.Millisecond);
            for (var i = 0; i < 10; i++)
            {
                response.Values.Add(randon.Next(0, 100));
            }

            return Task.FromResult(response);
        }
    }
}
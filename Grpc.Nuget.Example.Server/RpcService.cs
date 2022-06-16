using Grpc.Core;
using Grpc.Nuget.Example.Messages;
using Grpc.Nuget.Example.Service;

namespace Grpc.Nuget.Example.Server;

public class RpcService: ExampleService.ExampleServiceBase
{
    public override async Task<Response> CallRpc(Request request, ServerCallContext context)
    {
        await Task.Delay(TimeSpan.FromSeconds(1)); // Some work

        return new Response
        {
            Message = request.Message
        };
    }
}
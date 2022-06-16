using Grpc.Net.Client;
using Grpc.Nuget.Example.Messages;
using Grpc.Nuget.Example.Service;

var client = new ExampleService.ExampleServiceClient(GrpcChannel.ForAddress("https://localhost:7074"));

var response = await client.CallRpcAsync(new Request
{
    Message = "Hello, World!"
});

Console.WriteLine(response.Message);

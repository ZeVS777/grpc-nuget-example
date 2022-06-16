using System.Net;
using System.Security.Cryptography.X509Certificates;
using Microsoft.AspNetCore.Server.Kestrel.Core;

var builder = WebApplication.CreateBuilder(args);

//builder.WebHost.ConfigureKestrel(options =>
//{
//    options.Listen(IPAddress.Any, 5001, listenOptions =>
//    {
//        listenOptions.Protocols = HttpProtocols.Http2;
//        listenOptions.UseHttps(StoreName.My, "")
//    });
//})

builder.Services.AddGrpc();

var app = builder.Build();

app.MapGrpcService<RpcService>();
app.MapGet("/", () => "Hello World!");

app.Run();

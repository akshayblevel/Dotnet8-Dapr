using Consumer.Services;
using Dapr.Client;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDaprClient();
string daprPort = "3501";
builder.Services.AddSingleton<IItemService>(sc =>
        new ItemService(DaprClient.CreateInvokeHttpClient("daprservice", $"http://localhost:{daprPort}/v1.0/invoke/daprservice/method/")));
var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();
app.MapControllers();
app.Run();

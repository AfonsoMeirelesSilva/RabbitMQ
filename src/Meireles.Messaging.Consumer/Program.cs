using MassTransit;
using Meireles.Messaging.Consumer.Consumers;

var bus = Bus.Factory.CreateUsingRabbitMq(cfg =>
{
    cfg.Host("amqps://qfvveqfc:n6galJ-KEGkLzJ1mQSdEb4GtxMYjrfj3@stingray.rmq.cloudamqp.com/qfvveqfc");

    cfg.ReceiveEndpoint("agjl", e =>
    {
        e.Consumer<EmployeeConsumer>();
        e.Consumer<ProductConsumer>();
    });
});
Console.WriteLine("BUS STARTED");

await bus.StartAsync();
Console.ReadLine();
await bus.StopAsync();
Console.WriteLine("BUS FINIHSED");
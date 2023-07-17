using MassTransit;
using Meireles.Messaging.Contract.Domain;

namespace Meireles.Messaging.Consumer.Consumers
{
    public class EmployeeConsumer : IConsumer<Employee>
    {
        public async Task Consume(ConsumeContext<Employee> context)
        {
            await Console.Out.WriteLineAsync(@$"Employee -> {context.Message.Name} send by host -> {context.Host.MachineName} and MessageId -> {context.MessageId}");
        }
    }
}

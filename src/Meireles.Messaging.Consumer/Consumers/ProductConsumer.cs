using MassTransit;
using Meireles.Messaging.Contract.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Meireles.Messaging.Consumer.Consumers
{
    public class ProductConsumer : IConsumer<Product>
    {
        public async Task Consume(ConsumeContext<Product> context)
        {
            await Console.Out.WriteLineAsync("Product -> " + context.Message.Name);
        }
    }
}

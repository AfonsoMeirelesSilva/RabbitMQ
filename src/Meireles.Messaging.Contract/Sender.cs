using MassTransit;
using Meireles.Messaging.Contract.Domain;

namespace Meireles.Messaging.Contract
{
    internal class Sender : ISender
    {
        private readonly IPublishEndpoint _publishService;
        public Sender(IPublishEndpoint publishService)
        {
            _publishService = publishService;
        }

        public async Task PublishAsync<T>(T obj) where T : BaseDomain
        {
            await _publishService.Publish(obj);
        }
    }
}

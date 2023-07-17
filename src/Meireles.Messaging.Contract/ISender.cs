using Meireles.Messaging.Contract.Domain;

namespace Meireles.Messaging.Contract
{
    public interface ISender
    {
        Task PublishAsync<T>(T obj) where T : BaseDomain;
    }
}
using Meireles.Messaging.Contract.Domain;
using Meireles.Messaging.Contract.Extensions;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Meireles.Messaging.Producer.Infra.IoC
{
    public static class ProducerRabbitConfiguration
    {
        public static void AddRabbitMqConfiguration(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddMeirelesMessaging(new MessagingOption
            {
                UrlString = configuration["RabbitCredentials:UrlString"],
                Username = configuration["RabbitCredentials:Username"],
                Password = configuration["RabbitCredentials:Password"]
            });
        }
    }
}

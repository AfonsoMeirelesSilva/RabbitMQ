using MassTransit;
using Meireles.Messaging.Contract.Domain;
using Microsoft.Extensions.DependencyInjection;

namespace Meireles.Messaging.Contract.Extensions;

public static class MeirelesMessaginsInjections
{
    public static void AddMeirelesMessaging(this IServiceCollection service, MessagingOption options)
    {
        AddRabbitInjection(service, options);
    }

    private static void AddRabbitInjection(IServiceCollection service, MessagingOption options)
    {
        service.AddMassTransit(bus =>
        {
            bus.UsingRabbitMq((context, configurator) =>
            {
                configurator.Host(options.UrlString, conf =>
                {
                    conf.Username(options.Username);
                    conf.Password(options.Password);
                });
            });
        });
        service.AddScoped<ISender, Sender>();
    }
}

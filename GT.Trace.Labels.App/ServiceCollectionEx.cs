using MediatR;
using Microsoft.Extensions.DependencyInjection;

namespace GT.Trace.Labels.App
{
    public static class ServiceCollectionEx
    {
        public static IServiceCollection AddAppServices(this IServiceCollection services)
        {
            return services
                .AddSingleton<LineCode>()
                .AddMediatR(typeof(ServiceCollectionEx));
        }
    }
}
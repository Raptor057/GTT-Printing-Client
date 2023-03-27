using MediatR;
using Microsoft.Extensions.DependencyInjection;

namespace GT.Trace.Labels.Templates
{
    public static class ServiceCollectionEx
    {
        public static IServiceCollection AddTemplateServices(this IServiceCollection services)
        {
            return services
                .AddMediatR(typeof(ServiceCollectionEx));
        }
    }
}
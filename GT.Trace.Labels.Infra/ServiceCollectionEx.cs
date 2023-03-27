using GT.Trace.Labels.Templates;
using Microsoft.Extensions.DependencyInjection;

namespace GT.Trace.Labels.Infra
{
    public static class ServiceCollectionEx
    {
        public static IServiceCollection AddInfraServices(this IServiceCollection services)
        {
            return services
                .AddTransient<App.Services.IPrintersService, Services.SystemPrintersService>()
                .AddTransient<App.Services.ILabelPrintingService, Services.DevExpressLabelPrintingService>()
                .AddSingleton<App.Services.IMessageBusService, Services.MessageBusService>()
                .AddTransient<App.Services.IEtiMovementsNotificationsService, Services.SignalREtiMovementsClient>()
                .AddTransient<App.Services.IPackagingNotificationsService, Services.SignalRPackagingClient>()
                .AddTransient<App.Services.IPointsOfUseNotificationsService, Services.SignalRPointsOfUseClient>()
                .AddSingleton<DataStores.SqlDB.ISQLiteDBConnectionFactory, DataStores.SqlDB.SystemDirectorySQLiteDBConnectionFactory>()
                .AddTransient<App.Gateways.ILabelGateway, Gateways.SQLiteDBLabelGateway>()
                .AddTransient<App.Gateways.ISettingsGateway, Gateways.SQLiteSettingsGateway>()
                .AddTransient<DataStores.SqlDB.SQLiteSettingsDao>()
                .AddTemplateServices();
        }
    }
}
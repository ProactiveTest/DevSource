using Ijuba.Webapi.Application.Common.Interfaces;
using Ijuba.Webapi.Application.Common.Persistence;
using Ijuba.Webapi.Infrastructure.Caching;
using Ijuba.Webapi.Infrastructure.Common.Services;
using Ijuba.Webapi.Infrastructure.Localization;
using Ijuba.Webapi.Infrastructure.Persistence.ConnectionString;
using Microsoft.Extensions.Caching.Distributed;
using Microsoft.Extensions.Caching.Memory;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace Infrastructure.Test;

public class Startup
{
    public static void ConfigureHost(IHostBuilder host) =>
        host.ConfigureHostConfiguration(config => config.AddJsonFile("appsettings.json"));

    public static void ConfigureServices(IServiceCollection services, HostBuilderContext context) =>
        services
            .AddTransient<IMemoryCache, MemoryCache>()
            .AddTransient<LocalCacheService>()
            .AddTransient<IDistributedCache, MemoryDistributedCache>()
            .AddTransient<ISerializerService, NewtonSoftService>()
            .AddTransient<DistributedCacheService>()

            .AddPOLocalization(context.Configuration)

            .AddTransient<IConnectionStringSecurer, ConnectionStringSecurer>();
}
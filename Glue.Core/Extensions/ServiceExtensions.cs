using Microsoft.Extensions.DependencyInjection;

namespace Glue.Core.Extensions;

public static class ServiceExtensions {
    public static IServiceCollection AddGlueServices(this IServiceCollection services) {
        return services;
    }
}

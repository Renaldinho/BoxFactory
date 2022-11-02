using Domain.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace Application.DependancyResolver;

public static class DependencyResolverService
{
    public static void RegisterApplicationLayer(IServiceCollection services)
    {
        services.AddScoped<IBoxService, BoxService>();
    }
}
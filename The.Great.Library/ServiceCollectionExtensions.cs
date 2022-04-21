using EPiServer.Shell.Modules;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;

namespace The.Great.Library
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddTheGreatLibrary(
            this IServiceCollection services)
        {
            services.Configure<ProtectedModuleOptions>(
                pm =>
                {
                    if (!pm.Items.Any(i => i.Name.Equals(Constants.ModuleName, StringComparison.OrdinalIgnoreCase)))
                    {
                        pm.Items.Add(new() { Name = Constants.ModuleName });
                    }
                });

            return services;
        }
    }
}

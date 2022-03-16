using IdentityServer4.Models;
using Microsoft.Extensions.DependencyInjection;

namespace Notes.Identity
{
    public static class ServicesExtensions
    {
        public static void ConfigureIdentityServer(this IServiceCollection services)
        {
            services.AddIdentityServer()
                .AddInMemoryApiResources(new List<ApiResource>())
                .AddInMemoryIdentityResources(new List<IdentityResource>())
                .AddInMemoryApiScopes(new List<ApiScope>())
                .AddInMemoryClients(new List<Client>())
                .AddDeveloperSigningCredential();
        }
    }
}

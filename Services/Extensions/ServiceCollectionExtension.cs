using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Services.AppServices;
using Services.Interfaces;

namespace Services.Extensions;

public static class ServiceCollectionExtension
{
    public static void AddCustomServices(this IServiceCollection serviceCollection)
    {
        serviceCollection.AddRazorPages();
        serviceCollection.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();

        #region SpImovies

        serviceCollection.AddScoped<IClientesServices, ClientesService>();
        
       

        #endregion
        
    }
}
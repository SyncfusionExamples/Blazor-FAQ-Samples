using BlazorServerApp.Data;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

namespace BlazorServerApp
{
    public class Startup
    {
        public void Configure ( IApplicationBuilder app )
        {
            // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        }

        public void ConfigureServices ( IServiceCollection services )
        {
            services.AddRazorPages();
            services.AddServerSideBlazor();
            services.AddSingleton<WeatherForecastService>();
            services.AddScoped<BlazorServerApp.Data.RouteData>();
        }
    }
}


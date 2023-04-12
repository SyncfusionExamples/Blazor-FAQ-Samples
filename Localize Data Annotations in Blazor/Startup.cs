using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Localization;
using Microsoft.Extensions.Localization;

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
            // Register the IStringLocalizer service
            services.AddLocalization(options => options.ResourcesPath = "Resources");
            services.AddSingleton<IStringLocalizerFactory, ResourceManagerStringLocalizerFactory>();
            services.AddTransient(typeof(IStringLocalizer<>), typeof(StringLocalizer<>));

            // Set the default culture to "en-US"
            services.Configure<RequestLocalizationOptions>(options =>
            {
                options.DefaultRequestCulture = new RequestCulture("en-US");
            });
        }
    }
}

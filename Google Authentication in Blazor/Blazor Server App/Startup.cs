using Microsoft.AspNetCore.Builder;

namespace Blazor_Server_App
{
    public class Startup
    {
        public Startup ( IConfiguration configuration )
        {
            Configuration = configuration;
        }

        public IConfiguration? Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices ( IServiceCollection services )
        {
            services.AddAuthentication().AddGoogle(googleOptions =>
            {
#pragma warning disable CS8601 // Possible null reference assignment.
#pragma warning disable CS8602 // Dereference of a possibly null reference.
                googleOptions.ClientId = Configuration["Authentication:Google:Your Google ClientId"];
#pragma warning restore CS8602 // Dereference of a possibly null reference.
#pragma warning restore CS8601 // Possible null reference assignment.
#pragma warning disable CS8601 // Possible null reference assignment.
                googleOptions.ClientSecret = Configuration["Authentication:Google:Your Google ClientSecret here"];
#pragma warning restore CS8601 // Possible null reference assignment.
            });
        }
    }
}

using Microsoft.AspNetCore.Builder;

namespace ASP.Net_core_App_MVC
{
    public class Startup
    {
        public void ConfigureServices ( IServiceCollection services )
        {
            services.AddServerSideBlazor();
            services.AddControllersWithViews();
        }
        public void Configure ( IApplicationBuilder app, IWebHostEnvironment env )
        {           
             app.UseEndpoints(endpoints =>
             {
                 endpoints.MapControllerRoute(
                     name: "default",
                     pattern: "{controller=Home}/{action=Index}/{id?}");
                 endpoints.MapBlazorHub();
             });
        }
    }
}

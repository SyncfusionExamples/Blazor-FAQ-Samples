using Microsoft.AspNetCore.Builder;

namespace BlazorServerApp
{
    public class Startup
    {
        public void ConfigureServices ( IServiceCollection services )
        {
            services.AddRazorPages();
            services.AddServerSideBlazor();
            services.AddCors(options =>
            {
                options.AddPolicy("NewPolicy", builder =>
                 builder.AllowAnyOrigin()
                              .AllowAnyMethod()
                              .AllowAnyHeader());
            });
        }
        public void Configure ( IApplicationBuilder app, IWebHostEnvironment env )
        {
            app.UseRouting();
            app.UseCors("NewPolicy");
            app.UseAuthorization();

        }

    }
}

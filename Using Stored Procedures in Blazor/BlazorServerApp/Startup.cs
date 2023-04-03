using BlazorServerApp.Data;
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using BlazorServerApp.Services;
namespace BlazorServerApp
{
    public class Startup
    {
        public Startup(IConfiguration configuration) 
        {
            Configuration = configuration;
        }
        public IConfiguration Configuration { get; }
        
        public void ConfigureServices ( IServiceCollection services )
        {
            services.AddDbContext<ApplicationDbContext>(options => options.UseSqlServer("name=ConnectionStrings:Myconnection"));
            services.AddRazorPages();
            services.AddScoped<EmpService>();
        }
        public void Configure ( IApplicationBuilder app )
        {
            // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        }
    }
}

public class Startup
{
    public void Configure ( IApplicationBuilder app, IWebHostEnvironment env )
    {
        if (env.IsDevelopment())
        {
            app.UseWebAssemblyDebugging();
        }

        app.UseBlazorFrameworkFiles();
        app.UseEndpoints(endpoints =>
        {
            endpoints.MapFallbackToFile("index.html");
        });
    }
}
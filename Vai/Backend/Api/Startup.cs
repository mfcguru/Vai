using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace Vai.Backend.Api
{
    using Vai.Backend.Api.Helpers;
    using Vai.Backend.Core.Entities;
    using Vai.Backend.Core.UseCases.Process;
    using Vai.Shared.Interfaces.Process;

    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews();
            services.AddRazorPages();

            services.AddJwtAuthentication(AuthHelper.SECRET);

            services.AddDbContextPool<VaiContext>(context => context
                .UseLazyLoadingProxies()
                .UseSqlServer(Configuration["ConnectionStrings:VaiConnectionString"])
            );

            services.AddScoped<IAddProcessCommand, AddProcessCommand>();
            services.AddScoped<IDeleteProcessCommand, DeleteProcessCommand>();
            services.AddScoped<IEditProcessCommand, EditProcessCommand>();
            services.AddScoped<IGetAllProcessesCommand, GetAllProcessesCommand>();
            services.AddScoped<IGetProcessCommand, GetProcessCommand>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env, ILoggerProvider loggerProvider)
        {
            app.UseDeveloperExceptionPage();
            app.UseWebAssemblyDebugging();
            // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
            app.UseHsts();
            app.ConfigureExceptionHandler(loggerProvider.CreateLogger("default"));

            app.UseHttpsRedirection();
            app.UseBlazorFrameworkFiles();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapRazorPages();
                endpoints.MapControllers();
                endpoints.MapFallbackToFile("index.html");
            });
        }
    }
}

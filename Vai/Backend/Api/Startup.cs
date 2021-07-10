using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace Vai.Backend.Api
{
    using Vai.Backend.Core.Entities;
    using Vai.Backend.Core.UseCases.Process;
    using Vai.Shared.Interfaces;
    using Vai.Shared.Models;
    using Vai.Shared.Params;

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

            services.AddDbContextPool<VaiContext>(context => context
                .UseLazyLoadingProxies()
                .UseSqlServer(Configuration["ConnectionStrings:VaiConnectionString"])
            );

            services.AddScoped<ICommand<AddProcessCommandParams>, AddProcessCommand>();
            services.AddScoped<ICommand<DeleteProcessCommandParams>, DeleteProcessCommand>();
            services.AddScoped<ICommand<EditProcessCommandParameters>, EditProcessCommand>();
            services.AddScoped<ICommandList<GetAllProcessesCommandModel, GetAllProcessesCommandParams>, GetAllProcessesCommand>();
            services.AddScoped<ICommand<int, GetProcessCommandModel>, GetProcessCommand>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseWebAssemblyDebugging();
            }
            else
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

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

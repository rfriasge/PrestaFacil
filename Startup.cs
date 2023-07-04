using PrestaFacil.Services;
using PrestaFacil.Data;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Radzen;
using Microsoft.AspNetCore.Components.Authorization;
using PrestaFacil.Auth;
//using Microsoft.Extensions.Options;


namespace PrestaFacil
{
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

            services.AddSignalRCore();

            // En caso de que desees utilizar Azure SignalR
            //services.AddSignalRCore().AddAzureSignalR(Configuration.GetConnectionString("SignalR"));

            services.AddDbContext<ApplicationDbContext>(options =>
                options.UseSqlServer(
                    Configuration.GetConnectionString("DbPrestamos")),
                    ServiceLifetime.Transient);

            //services.AddDbContext<ApplicationDbContext>(
            //   options => options.UseSqlServer(Configuration.GetConnectionString("DbPrestamos")));
            services.AddRazorPages();
            services.AddServerSideBlazor();
            services.AddSingleton<WeatherForecastService>();
            services.AddTransient<ICompaniaService, CompaniaService>();
            services.AddTransient<IClienteService, ClienteService>();
            services.AddTransient<ITipoClienteService, TipoClienteService>();
            services.AddTransient<IAmortizacion, AmortizacionService>();
            services.AddTransient<IPrestamoService, PrestamoService>();
            services.AddTransient<IPrestamoDetalleService, PrestamoDetalleService>();
            services.AddTransient<ICobroService, CobroService>();
            services.AddTransient<ICobradorService, CobradorService>();
            services.AddTransient<ITipoTransaccionService, TipoTransaccionService>();
            services.AddScoped<NotificationService>();
            services.AddAuthenticationCore();
            services.AddScoped<AuthenticationStateProvider, ProveedorAutenticacionPrueba>();
            


        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Error");
            }

            app.UseStaticFiles();

            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapBlazorHub();
                endpoints.MapFallbackToPage("/_Host");
            });
        }
    }
}

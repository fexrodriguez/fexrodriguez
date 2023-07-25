using FactoryPlatform.Data;
using FactoryPlatform.Data.AppDbContext;
using FactoryPlatform.Filter;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.FileProviders;
using Microsoft.Extensions.Hosting;
using Microsoft.Identity.Web;
using Microsoft.Identity.Web.UI;
using Microsoft.IdentityModel.Protocols.OpenIdConnect;
using System;
using System.IO;
using System.Net;

namespace FactoryPlatform
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }
        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddSingleton<IConfiguration>(Configuration);
            services.AddDbContext<ApplicationDbContext>(options => options.UseSqlServer(Configuration.GetConnectionString("fp_lkq_motors")));
            services.AddDbContext<LKQMXFPAPPContext>(options => options.UseSqlServer(Configuration.GetConnectionString("fp_lkq_motors")));
            services.AddDbContext<StoresProceduresDbContext>(options => options.UseSqlServer(Configuration.GetConnectionString("fp_lkq_motors")));

            services.Configure<CookiePolicyOptions>(options =>
            {
                // This lambda determines whether user consent for non-essential cookies is needed for a given request.
                options.CheckConsentNeeded = context => true;
                options.MinimumSameSitePolicy = SameSiteMode.Unspecified;

                // Handling SameSite cookie according to https://docs.microsoft.com/en-us/aspnet/core/security/samesite?view=aspnetcore-3.1
                options.HandleSameSiteCookieCompatibility();
            });

            services.AddAuthentication(options =>
            {
                options.DefaultSignInScheme = CookieAuthenticationDefaults.AuthenticationScheme;
                options.DefaultAuthenticateScheme = CookieAuthenticationDefaults.AuthenticationScheme;
                options.DefaultChallengeScheme = CookieAuthenticationDefaults.AuthenticationScheme;
            }).AddOpenIdConnect(options =>
            {
                options.Authority = options.Authority = $"{Configuration["AzureAd:Instance"]}{Configuration["AzureAd:TenantId"]}{Configuration["AzureAd:ClientCapabilities"]}";
                options.ClientId = $"{Configuration["AzureAd:ClientId"]}";
                options.ResponseType = OpenIdConnectResponseType.IdToken;
                options.CallbackPath = "/Login";
                options.SignedOutRedirectUri = "https://mxesc1vapp001";
            }).AddCookie(options =>
            {
                options.ExpireTimeSpan = TimeSpan.FromHours(10);
                options.LoginPath = "/Login/";
            });

            services.AddScoped<ActionMethodServiceNowFilter>();
            services.AddScoped<AuthorizeActionFilter>();//Filter to Action the pages
            services.AddScoped<AuthorizeMethodFilter>();//Filter to Method of the pages
            services.AddScoped<FilterNoCacheAttribute>();//Filter that no return to somepage when does not cookie and session.
            services.AddAntiforgery(o => o.HeaderName = "XSRF-TOKEN");///Globaliza la antiforainKey
            services.AddRazorPages().AddMicrosoftIdentityUI();
            services.AddControllersWithViews().AddMicrosoftIdentityUI();
            services.AddServerSideBlazor().AddMicrosoftIdentityConsentHandler();
            services.AddControllers();
            services.AddOptions();
            services.AddMvc();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            //if (env.IsDevelopment())
            //{
            //    app.UseDeveloperExceptionPage();
            //    app.UseDatabaseErrorPage();
            //}
            if (env.IsProduction())
            {
                app.UseDeveloperExceptionPage();
                app.UseDatabaseErrorPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            //app.UseFileServer(new FileServerOptions
            //{
            //    FileProvider = new PhysicalFileProvider("z:\\Proof1"),
            //    RequestPath = "/Proof1",
            //    EnableDirectoryBrowsing = true
            //});

            app.UseRouting();
            app.UseCookiePolicy(
            new CookiePolicyOptions
            {
                Secure = CookieSecurePolicy.Always
            });
            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                   name: "default",
                   pattern: "{controller=Login}/{action=Index}/{id?}"
                );

                endpoints.MapControllerRoute("Sections", "{controller=Sections}/{action=Pages}/{id?}");
                endpoints.MapAreaControllerRoute("ServiceNow", "ServiceNow", "{controller=Home}/{action=SystemHost}/{id?}");
                endpoints.MapAreaControllerRoute("Administrator", "Administrator", "{controller=Administrator}/{action=Users}/{id?}");
                //Descripcion, Area/Controller/Accion
                endpoints.MapAreaControllerRoute("Quality", "Quality", "{controller=QualityControl}/{action=ModelFeatures}/{id?}");
                endpoints.MapAreaControllerRoute("Quality", "Quality", "{controller=QualityControl}/{action=BeforeProof}/{id?}");
                endpoints.MapAreaControllerRoute("Quality", "Quality", "{controller=PhotoCenter}/{action=PhotoCenterBeforeProof}/{id?}");
                endpoints.MapAreaControllerRoute("Quality", "Quality", "{controller= DocumentControl}/{action= DocumentList}/{id?}");
                endpoints.MapRazorPages();
            });


        }
    }
}

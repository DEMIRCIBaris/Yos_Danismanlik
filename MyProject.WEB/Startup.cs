using FluentValidation.AspNetCore;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using MyProject.Bussiness.Extensions.DIResolvers;
using MyProject.Bussiness.Extensions.IdentityConfigurations;
using MyProject.Bussiness.Extensions.ValidationConfig;
using MyProject.DataAccess.Concrete.EntityFramework.Context;
using MyProject.Entities.Concrete.IdentityLibraryEntites;
using MyProject.WEB.Functions;

namespace MyProject.WEB
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews().AddFluentValidation();
            //CODEvils Data Transfer Object
            services.AddDbContext<MyDataContext>();
            services.AddContainerWithDependencies(); //DI iþleri bundan sorulur
            services.AddIdentityConfiguration();
            services.CookieConfigurations("/Home/Login");
            services.ValidatorConfig();

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env,UserManager<AppUser> userManager,RoleManager<AppRole> roleManager)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            IdentityInitilaizer.SeedData(userManager,roleManager).Wait();

            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();

            app.UseStaticFiles();

            app.UseEndpoints(endpoints =>
            {
              
                endpoints.MapControllerRoute(
                    name:"areas",
                    pattern:"{area}/{controller=Home}/{action=Index}/{id?}"
                    );

                endpoints.MapControllerRoute(
                  name: "default",
                  pattern: "{controller=Static}/{action=Index}/{id?}"
                  );
            });
        }
    }
}

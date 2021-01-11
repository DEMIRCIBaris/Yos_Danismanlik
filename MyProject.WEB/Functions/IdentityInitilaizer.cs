using Microsoft.AspNetCore.Identity;
using MyProject.Entities.Concrete.IdentityLibraryEntites;
using System.Threading.Tasks;

namespace MyProject.WEB.Functions
{
    public static class IdentityInitilaizer
    {
        public static async Task SeedData(UserManager<AppUser> userManager,RoleManager<AppRole> roleManager)
        {
            var adminRole = await roleManager.FindByNameAsync("Admin");
            if (adminRole==null)
            {
                await roleManager.CreateAsync(new AppRole { Name="Admin"});
            }

            var memberRole = await roleManager.FindByNameAsync("Member");
            if (memberRole == null)
            {
                await roleManager.CreateAsync(new AppRole { Name = "Member" });
            }

            var adminUser = await userManager.FindByNameAsync("Dancho");
            if (adminUser==null)
            {
                var appuser = new AppUser 
                {
                    UserName="Dancho" ,
                    Name="Barış",
                    Surname="Demirci",
                    Email="baris@gmail.com"
                };
                await userManager.CreateAsync(appuser,"1");
                await userManager.AddToRoleAsync(appuser, "Admin");
            }
        }
    }
}

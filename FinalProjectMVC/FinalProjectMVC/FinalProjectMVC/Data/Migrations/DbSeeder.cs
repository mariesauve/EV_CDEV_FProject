using Microsoft.AspNetCore.Identity;
using FinalProjectMVC.Constraints;
using Azure.Identity;

namespace FinalProjectMVC.Data
{
    public class DbSeeder
    {
        public static async Task SeedDefaultDataAsync(IServiceProvider service)
        {
            var userMgr = service.GetService<UserManager<IdentityUser>>();
          
            var roleMgr = service.GetService<RoleManager<IdentityRole>>();

            // create an admin user
            var admin = new IdentityUser
            {
                UserName = "admin1@gmail.com",
                Email = "admin1@gmail.com",
                EmailConfirmed = true
            };
        
        }
    }
}

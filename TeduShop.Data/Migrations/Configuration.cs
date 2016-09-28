namespace TeduShop.Data.Migrations
{
    using Microsoft.AspNet.Identity;
    using Microsoft.AspNet.Identity.EntityFramework;
    using Model.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<TeduShop.Data.TeduShopDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(TeduShop.Data.TeduShopDbContext context)
        {
            //  This method will be called after migrating to the latest version.
            var manger = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(new TeduShopDbContext()));
            var roleManger = new RoleManager<IdentityRole>(new RoleStore<IdentityRole>(new TeduShopDbContext()));

            var user = new ApplicationUser()
            {
                UserName = "Admin",
                Email = "thuybuicntt@Gmail.com",
                Birthday = DateTime.Now,
                EmailConfirmed = true,
                FullName = "bui dinht thuy"


            };
            manger.Create(user, "123456$");
            if(!roleManger.Roles.Any())
            {
                roleManger.Create(new IdentityRole { Name = "Admin" });
                roleManger.Create(new IdentityRole { Name = "User" });
            }
             
            var adminUser = manger.FindByEmail("thuybuicntt@Gmail.com");
            manger.AddToRoles(adminUser.Id, new string[] { "Admin", "User" });
        }
    }
}

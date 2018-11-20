namespace Home1Azure.Migrations
{
    using Home1Azure.Models;
    using Microsoft.AspNet.Identity;
    using Microsoft.AspNet.Identity.EntityFramework;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Home1Azure.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Home1Azure.Models.ApplicationDbContext context)
        {
            //var userManager = new ApplicationUserManager(new UserStore<ApplicationUser>(context));
            //var roleManager = new RoleManager<IdentityRole>(new RoleStore<IdentityRole>(context));

            //var userRole = new IdentityRole { Name = "user" };
            //roleManager.Create(userRole);

            //ApplicationUser user = new ApplicationUser { UserName = "vasya@gmail.com", Email = "vasya@gmail.com", PhoneNumber = "+380980630555" };
            //var result = userManager.Create(user, "Qwerty1-");

            //if (result.Succeeded)
            //{
            //    userManager.AddToRole(user.Id, userRole.Name);
            //}

            context.Roles.AddOrUpdate(r => r.Name, new IdentityRole() {Id=Guid.NewGuid().ToString(), Name = "Admin" });
            context.SaveChanges();



            //if (!context.Roles.Any(r => r.Name == "Admin"))
            //{
            //    var store = new RoleStore<IdentityRole>(context);
            //    var manager = new RoleManager<IdentityRole>(store);
            //    var role = new IdentityRole { Name = "Admin" };

            //    manager.Create(role);
            //}

            //if (!context.Users.Any(u => u.UserName == "nick"))
            //{
            //    var store = new UserStore<ApplicationUser>(context);
            //    var manager = new UserManager<ApplicationUser>(store);
            //    var user = new ApplicationUser { UserName = "nick" };

            //    manager.Create(user, "Qwerty1-");
            //    manager.AddToRole(user.Id, "Admin");
            //}
        }
    }
}

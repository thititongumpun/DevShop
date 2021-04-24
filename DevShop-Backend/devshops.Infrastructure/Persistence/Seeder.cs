using devshops.Infrastructure.Identity;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace devshops.Infrastructure.Persistence
{
    public class Seeder
    {
        private AppDbContext context;
        public Seeder(AppDbContext context)
        {
            this.context = context;
        }

        public async void SeedAdminUser()
        {
            var admin = new ApplicationUser
            {
                Id = Guid.NewGuid().ToString(),
                UserName = "Admin",
                NormalizedUserName = "ADMIN",
                Email = "Admin@localhost.com",
                NormalizedEmail = "ADMIN@LOCALHOST.COM",
                SecurityStamp = Guid.NewGuid().ToString()
            };

            var user = new ApplicationUser
            {
                Id = Guid.NewGuid().ToString(),
                UserName = "User1",
                NormalizedUserName = "USER1",
                Email = "USER1@localhost.com",
                NormalizedEmail = "USER1@LOCALHOST.COM",
                SecurityStamp = Guid.NewGuid().ToString()
            };

            var roleStore = new RoleStore<IdentityRole>(context);

            if (!context.Roles.Any())
            {
                await roleStore.CreateAsync(new IdentityRole { Name = Roles.Admin, NormalizedName = Roles.Admin });
                await roleStore.CreateAsync(new IdentityRole { Name = Roles.User, NormalizedName = Roles.User });
            }

            if (!context.Users.Any())
            {
                var password = new PasswordHasher<ApplicationUser>();
                var hashedAdmin = password.HashPassword(admin, "12345");
                admin.PasswordHash = hashedAdmin;
                var userStore = new UserStore<ApplicationUser>(context);
                await userStore.CreateAsync(admin);
                await userStore.AddToRoleAsync(admin, Roles.Admin);

                var hashedUser = password.HashPassword(user, "12345");
                user.PasswordHash = hashedUser;
                await userStore.CreateAsync(user);
                await userStore.AddToRoleAsync(user, Roles.User);
            }

            await context.SaveChangesAsync();
        }
    }
}

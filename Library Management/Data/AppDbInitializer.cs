using Library_Management.Models;
using Microsoft.AspNetCore.Builder;

namespace Library_Management.Data
{
    public class AppDbInitializer
    {
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<ApplicationDbContext>();
                context.Database.EnsureCreated();

                // Check if there are any users in the database
                if (!context.Users.Any(u => u.UserType == EnumUserType.Admin))
                {
                    // If no users exist, add an Admin user
                    var user = new User
                    {
                        // Set user properties here
                        Name = "SuperAdmin",
                        Email = "admin@gmail.com",
                        Phone = "123456789",
                        Password = "admin",
                        Faculty = "IT",
                        UserType = EnumUserType.Admin
                    };
                    context.Users.Add(user);
                    context.SaveChanges();
                }
            }
        }


        internal static void Seed()
        {
            throw new NotImplementedException();
        }
    }

}



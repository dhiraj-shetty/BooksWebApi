using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using my_books.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// This Class is used to implement a static method called Seed
// Seed method will initialise only an Empty Database with Seed Data

namespace my_books.Data
{
    public class AppDbInitialiser
    {
        public static void Seed(IApplicationBuilder app)
        {
            using (var serviceScope = app.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<AppDbContext>();

                if (!context.Books.Any())
                {
                    Book SeedBook1 = new Book() { Title = "1st Seeded Title", Description = "1st Seeded Description", IsRead = true, DateRead = DateTime.Now.AddDays(-10), Rate = 4, DateAdded = DateTime.Now, Genre = "1st Seeded Genre", Author = "1st Seeded Author", CoverURL = "https://1stSeededUrl" };
                    Book SeedBook2 = new Book() { Title = "2nd Seeded Title", Description = "2nd Seeded Description", IsRead = true, DateRead = DateTime.Now.AddDays(-5), Rate = 5, DateAdded = DateTime.Now, Genre = "2nd Seeded Genre", Author = "2nd Seeded Author", CoverURL = "https://2ndSeededUrl" };

                    context.Books.Add(SeedBook1);
                    context.Books.Add(SeedBook2);

                    context.SaveChanges();
                }
            }
        }
    }
}

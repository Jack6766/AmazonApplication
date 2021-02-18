using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AmazonApplication.Models
{
    public class SeedData
    {
        public static void EnsurePopulated(IApplicationBuilder application)
        {
            AmazonDbContext context = application.ApplicationServices.
                CreateScope().ServiceProvider.GetRequiredService<AmazonDbContext>;

            if (context.Database.GetPendingMigrations().Any())
            {
                context.Database.Migrate();
            }

            if (!context.Books.Any())
            {
                context.Books.AddRange(

                    new Book
                    {
                        BookID = 1,
                        Title = "Les Miserables",
                        AuthorFirst = "Victor",
                        AuthorLast = "Hugo",
                        Publisher = "Signet",
                        ISBN = "978-0451419439",
                        Category1 = "Fiction",
                        Category2 = "Classic",
                        Price = 9.95
                    },

                    new Book
                    {
                        BookID = 2,
                        Title = "Team of Rivals",
                        AuthorFirst = "Doris Kearns",
                        AuthorLast = "Goodwin",
                        Publisher = "Simon & Schuster",
                        ISBN = "978-0743270755",
                        Category1 = "Non-Fiction",
                        Category2 = "Biography",
                        Price = 14.58
                    },

                    new Book
                    {
                        BookID = 3,
                        Title = "The Snowball",
                        AuthorFirst = "Alice",
                        AuthorLast = "Schroeder",
                        Publisher = "Bantam",
                        ISBN = "978-0553384611",
                        Category1 = "Non-Fiction",
                        Category2 = "Biography",
                        Price = 21.54
                    },

                    new Book
                    {
                        BookID = 4,
                        Title = "American Ulysses",
                        AuthorFirst = "Ronald C.",
                        AuthorLast = "White",
                        Publisher = "Random House",
                        ISBN = "978-0812981254",
                        Category1 = "Non-Fiction",
                        Category2 = "Biography",
                        Price = 11.61
                    },

                    new Book
                    {
                        BookID = 5,
                        Title = "Unbroken",
                        AuthorFirst = "Laura",
                        AuthorLast = "Hillenbrand",
                        Publisher = "Random House",
                        ISBN = "978-0812974492",
                        Category1 = "Non-Fiction",
                        Category2 = "Historical",
                        Price = 13.33
                    },

                    new Book
                    {
                        BookID = 6,
                        Title = "The Great Train Robbery",
                        AuthorFirst = "Michael",
                        AuthorLast = "Crichton",
                        Publisher = "Vintage",
                        ISBN = "978-0804171281",
                        Category1 = "Fiction",
                        Category2 = "Historical Fiction",
                        Price = 15.95
                    },

                    new Book
                    {
                        BookID = 7,
                        Title = "Deep Work",
                        AuthorFirst = "Cal",
                        AuthorLast = "Newport",
                        Publisher = "Grand Central Publishing",
                        ISBN = "978-1455586691",
                        Category1 = "Non-Fiction",
                        Category2 = "Self-Help",
                        Price = 14.99
                    },

                    new Book
                    {
                        BookID = 8,
                        Title = "It's Your Ship",
                        AuthorFirst = "Michael",
                        AuthorLast = "Abrashoff",
                        Publisher = "Grand Central Publishing",
                        ISBN = "978-1455523023",
                        Category1 = "Non-Fiction",
                        Category2 = "Self-Help",
                        Price = 21.66
                    },

                    new Book
                    {
                        BookID = 9,
                        Title = "The Virgin Way",
                        AuthorFirst = "Richard",
                        AuthorLast = "Branson",
                        Publisher = "Portfolio",
                        ISBN = "978-1591847984",
                        Category1 = "Non-Fiction",
                        Category2 = "Business",
                        Price = 29.16
                    },

                    new Book
                    {
                        BookID = 10,
                        Title = "Sycamore Row",
                        AuthorFirst = "John",
                        AuthorLast = "Grisham",
                        Publisher = "Bantam",
                        ISBN = "978-0553393613",
                        Category1 = "Fiction",
                        Category2 = "Thrillers",
                        Price = 15.03
                    }
                );

                context.SaveChanges();
            }
        }
    }
}

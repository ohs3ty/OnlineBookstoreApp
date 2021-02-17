using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;

namespace OnlineBookstoreApp.Models
{
    public class SeedData
    {
        public static void EnsurePopulated(IApplicationBuilder application)
        {
            BookstoreDBContext context = application.ApplicationServices.CreateScope().ServiceProvider.GetRequiredService<BookstoreDBContext>();

            if (context.Database.GetPendingMigrations().Any())
            {
                context.Database.Migrate();
            } 

            if (!context.Books.Any())
            {
                context.Books.AddRange(
                    //List of books
                    new Book
                    {
                        Title = "Les Miserables",
                        Author = "Victor Hugo",
                        Publisher = "Signet",
                        ISBN = "978-0451419439",
                        MainCategory = "Classic",
                        Price = 9.95f,
                    },

                    new Book
                    {
                        Title = "Team of Rivals",
                        Author = "Doris Kearns Goodwin",
                        Publisher = "Simon & Schuster",
                        ISBN = "978-0743270755",
                        MainCategory = "Biography",
                        Price = 14.58f,
                    },

                    new Book
                    {
                        Title = "The Snowball",
                        Author = "Alice Schroeder",
                        Publisher = "Bantam",
                        ISBN = "978-0553384611",
                        MainCategory = "Biography",
                        Price = 21.45f,
                    },

                    new Book
                    {
                        Title = "American Ulysses",
                        Author = "Ronald C. White",
                        Publisher = "Random House",
                        ISBN = "978-0812981254",
                        MainCategory = "Biography",
                        Price = 11.61f,
                    },

                    new Book
                    {
                        Title = "Unbroken",
                        Author = "Laura Hillenbrand",
                        Publisher = "Random House",
                        ISBN = "978-0812974492",
                        MainCategory = "Historical",
                        Price = 13.33f,
                    },

                    new Book
                    {
                        Title = "The Great Train Robbery",
                        Author = "Michael Crichton",
                        Publisher = "Vintage",
                        ISBN = "978-0804171281",
                        MainCategory = "Historical Fiction",
                        Price = 15.95f,
                    }, 

                    new Book
                    {
                        Title = "Deep Work",
                        Author = "Cal Newport",
                        Publisher = "Grand Central Publishing",
                        ISBN = "978-1455586691",
                        MainCategory = "Self-Help",
                        Price = 14.99f,
                    },

                    new Book
                    {
                        Title = "It's Your Ship",
                        Author = "Michael Abrashoff",
                        Publisher = "Grand Central Publishing",
                        ISBN = "978-1455523023",
                        MainCategory = "Self-Help",
                        Price = 21.66f,
                    },

                    new Book
                    {
                        Title = "The Virgin Way",
                        Author = "Richard Branson",
                        Publisher = "Portfolio",
                        ISBN = "978-1591847984",
                        MainCategory = "Business",
                        Price = 29.16f,
                    },

                    new Book
                    {
                        Title = "Sycamore Row",
                        Author = "John Grisham",
                        Publisher = "Bantam",
                        ISBN = "978-0553393613",
                        MainCategory = "Thriller",
                        Price = 15.03f,
                    }

                    );
            context.SaveChanges();
            }

        }
    }
}

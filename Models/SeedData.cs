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
                        AuthorFirst = "Victor",
                        AuthorLast = "Hugo",
                        Publisher = "Signet",
                        ISBN = "978-0451419439",
                        Classification = "Fiction",
                        Category = "Classic",
                        Price = 9.95f,
                        NumPages = 1488,
                    },

                    new Book
                    {
                        Title = "Team of Rivals",
                        AuthorFirst = "Doris",
                        AuthorMiddle = "Kearns",
                        AuthorLast = "Goodwin",
                        Publisher = "Simon & Schuster",
                        ISBN = "978-0743270755",
                        Classification = "Non-Fiction",
                        Category = "Biography",
                        Price = 14.58f,
                        NumPages = 944,
                    },

                    new Book
                    {
                        Title = "The Snowball",
                        AuthorFirst = "Alice",
                        AuthorLast = "Schroeder",
                        Publisher = "Bantam",
                        ISBN = "978-0553384611",
                        Classification = "Non-Fiction",
                        Category = "Biography",
                        Price = 21.45f,
                        NumPages = 832,
                    },

                    new Book
                    {
                        Title = "American Ulysses",
                        AuthorFirst = "Ronald",
                        AuthorMiddle = "C.",
                        AuthorLast = "White",
                        Publisher = "Random House",
                        ISBN = "978-0812981254",
                        Classification = "Non-Fiction",
                        Category = "Biography",
                        Price = 11.61f,
                        NumPages = 864,
                    },

                    new Book
                    {
                        Title = "Unbroken",
                        AuthorFirst = "Laura",
                        AuthorLast = "Hillenbrand",
                        Publisher = "Random House",
                        ISBN = "978-0812974492",
                        Classification = "Non-Fiction",
                        Category = "Historical",
                        Price = 13.33f,
                        NumPages = 528,
                    },

                    new Book
                    {
                        Title = "The Great Train Robbery",
                        AuthorFirst = "Michael",
                        AuthorLast = "Crichton",
                        Publisher = "Vintage",
                        ISBN = "978-0804171281",
                        Classification = "Fiction",
                        Category = "Historical Fiction",
                        Price = 15.95f,
                        NumPages = 288,
                    },

                    new Book
                    {
                        Title = "Deep Work",
                        AuthorFirst = "Cal",
                        AuthorLast = "Newport",
                        Publisher = "Grand Central Publishing",
                        ISBN = "978-1455586691",
                        Classification = "Non-Fiction",
                        Category = "Self-Help",
                        Price = 14.99f,
                        NumPages = 304,
                    },

                    new Book
                    {
                        Title = "It's Your Ship",
                        AuthorFirst = "Michael",
                        AuthorLast = "Abrashoff",
                        Publisher = "Grand Central Publishing",
                        ISBN = "978-1455523023",
                        Classification = "Non-Fiction",
                        Category = "Self-Help",
                        Price = 21.66f,
                        NumPages = 240,
                    },

                    new Book
                    {
                        Title = "The Virgin Way",
                        AuthorFirst = "Richard",
                        AuthorLast = "Branson",
                        Publisher = "Portfolio",
                        ISBN = "978-1591847984",
                        Classification = "Non-Fiction",
                        Category = "Business",
                        Price = 29.16f,
                        NumPages = 400,
                    },

                    new Book
                    {
                        Title = "Sycamore Row",
                        AuthorFirst = "John",
                        AuthorLast = "Grisham",
                        Publisher = "Bantam",
                        ISBN = "978-0553393613",
                        Classification = "Fiction",
                        Category = "Thriller",
                        Price = 15.03f,
                        NumPages = 642,
                    },

                    new Book
                    {
                        Title = "The Mysterious Benedict Society",
                        AuthorFirst = "Trenton",
                        AuthorMiddle = "Lee",
                        AuthorLast = "Stewart",
                        Publisher = "Little, Brown and Company",
                        ISBN = "978-0316464918",
                        Classification = "Fiction",
                        Category = "Adventure",
                        Price = 9.83f,
                        NumPages = 485,
                    },

                    new Book
                    {
                        Title = "Harry Potter and the Deathly Hallows",
                        AuthorFirst = "J.",
                        AuthorMiddle = "K.",
                        AuthorLast = "Rowling",
                        Publisher = "Bloomsbury Publishing",
                        ISBN = "978-0739360385",
                        Classification = "Fiction",
                        Category = "Fantasy",
                        Price = 10.49f,
                        NumPages = 607,
                    },

                    new Book
                    {
                        Title = "The Westing Game",
                        AuthorFirst = "Ellen",
                        AuthorLast = "Raskin",
                        Publisher = "E. P. Dutton",
                        ISBN = "978-0142401200",
                        Classification = "Fiction",
                        Category = "Mystery",
                        Price = 7.99f,
                        NumPages = 216,
                    }

                    ) ;
            context.SaveChanges();
            }

        }
    }
}

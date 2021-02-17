using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace OnlineBookstoreApp.Models
{
    public class BookstoreDBContext : DbContext
    {
        public BookstoreDBContext (DbContextOptions<BookstoreDBContext> options) : base (options)
        {

        }

        public DbSet<Book> Books { get; set; }
     }
}

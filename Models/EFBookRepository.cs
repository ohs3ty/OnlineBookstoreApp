using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineBookstoreApp.Models
{
    public class EFBookRepository : iBookRepository
    {
        private BookstoreDBContext _context;
        //Constructor
        public EFBookRepository (BookstoreDBContext context)
        {
            _context = context;
        }
        public IQueryable<Book> Books => _context.Books;
    }
}

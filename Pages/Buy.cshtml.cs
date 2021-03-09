using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using OnlineBookstoreApp.Infrastructure;
using OnlineBookstoreApp.Models;

namespace OnlineBookstoreApp.Pages
{
    public class BuyModel : PageModel
    {
        private iBookRepository repository;

        public BuyModel(iBookRepository repo, Cart cartService)
        {
            repository = repo;
            Cart = cartService;
        }

        public Cart Cart { get; set; }
        public string ReturnUrl { get; set; }
        public void OnGet(string returnUrl)
        {
            ReturnUrl = returnUrl ?? "/";
        }   

        public IActionResult OnPost (long bookId, string returnUrl)
        {
            Book book = repository.Books
                .FirstOrDefault(b => b.BookId == bookId);
            Cart.AddItem(book, 1);
            //if null set new cart  
            return RedirectToPage(new { returnUrl = returnUrl });
        }

        public IActionResult OnPostRemove(long bookId, string returnUrl)
        {
            Cart.RemoveLine(Cart.Lines.First(cl => cl.Book.BookId == bookId).Book);
            return RedirectToPage(new { returnUrl = returnUrl });
        }
    }
}

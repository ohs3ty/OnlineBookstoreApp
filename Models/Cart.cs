using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineBookstoreApp.Models
{
    public class Cart
    {
        public List<CartLine> Lines { get; set; } = new List<CartLine>();

        public virtual void AddItem(Book book, int quantity)
        {
            CartLine line = Lines
                .Where(b => b.Book.BookId == book.BookId)
                .FirstOrDefault();

            if (line == null)
            {
                Lines.Add(new CartLine {
                    Book = book,
                    Quantity = quantity
                });
            } else
            {
                line.Quantity += quantity;
            }
        }

        public virtual void RemoveLine(Book book) =>
            Lines.RemoveAll(x => x.Book.BookId == book.BookId);

        //Calculating total value
        public decimal ComputeTotalValue() =>
            Lines.Sum(e => (decimal)(e.Book.Price) * e.Quantity);

        //clear out the cart lines
        public virtual void Clear() => Lines.Clear();
    }

    public class CartLine
    {
        public int CartLineId { get; set; }
        public Book Book { get; set; }
        public int Quantity { get; set; }
    }
}

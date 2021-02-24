using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineBookstoreApp.Models
{
    public class Book
    {
        [Key]
        [Required]
        public int BookId { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public string AuthorFirst { get; set; }
        public string? AuthorMiddle { get; set; }
        [Required]
        public string AuthorLast { get; set; }
        [Required]
        public string Publisher { get; set; }
        [Required]
        [RegularExpression(@"^(?= (?:\D *\d){10}(?:(?:\D*\d){3})?$)[\d-]+$", ErrorMessage = "Invalid ISBN format")]
        public string ISBN { get; set; }
        [Required]
        public string Classification { get; set; }
        public string Category { get; set; }
        [Required]
        public float Price { get; set; }
        [Required]
        public int NumPages { get; set; }
    }
}

using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ebookstore.Models
{
    public class Book
    {
        [Key] public int bookId { get; set; }
        public string bookTitle { get; set; }
        public int bookPrice { get; set; }
        public string bookLanguage { get; set; }
        public string bookDescription { get; set; }

    }
}

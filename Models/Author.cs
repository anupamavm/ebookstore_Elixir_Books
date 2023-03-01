using System.ComponentModel.DataAnnotations;

namespace ebookstore.Models
{
    public class Author
    {
        [Key]
        public int authorId { get; set; }
        public string authorName { get; set; }

    }
}

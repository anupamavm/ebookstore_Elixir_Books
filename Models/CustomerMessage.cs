using System.ComponentModel.DataAnnotations;

namespace ebookstore.Models
{
    public class CustomerMessage
    {
        [Key]
        public string customerEmail { get; set; }
        public string customerName { get; set; }
        public string message { get; set; }
    }
}

using System.ComponentModel.DataAnnotations;

namespace ebookstore.Models
{
    public class Customer
    {
        [Key] public int customerId { get; set; }
        public string customerName { get; set; }
        public string customerEmail { get; set; }
       
    }
}

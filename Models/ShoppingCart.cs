using System.ComponentModel.DataAnnotations;

namespace ebookstore.Models
{
    public class ShoppingCart
    {
        [Key]
        public int orderId { get; set; }
        public int totalPrice { get; set; }
        public int quantity { get; set; }
    }
}

using System.ComponentModel.DataAnnotations;

namespace ebookstore.Models
{
    public class Admin
    {
        [Key]
        public int adminId { get; set; }
        public string adminName { get; set; }
    }
}

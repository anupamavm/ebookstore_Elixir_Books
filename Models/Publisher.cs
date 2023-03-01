using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;

namespace ebookstore.Models
{
    public class Publisher
    {
        [Key]
        public int publisherId { get; set; }
        public string publisherName { get; set; }
        public string publisherCountry { get; set; }
    }
}

using System.ComponentModel.DataAnnotations;

namespace Models
{
    public class Book
    {
        [Key]
        public int id { get; set; }
        public decimal price { get; set; }
        public string isbn { get; set; }
    }
}
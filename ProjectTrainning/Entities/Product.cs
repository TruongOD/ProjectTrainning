using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ProductManager.Entity
{
    [Table("Products")]
    public class Product : User
    {
        [Required]
        [StringLength(100)]
        public string Name { get; set; }

        public double Price { get; set; }
        public int Quantity { get; set; }
    }
}
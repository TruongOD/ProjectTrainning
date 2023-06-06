using System.ComponentModel.DataAnnotations.Schema;

namespace ProductManager.Entity
{
    [Table("Brands")]
    public class Brand : Base
    {
        public string Name { get; set; }
    }
}

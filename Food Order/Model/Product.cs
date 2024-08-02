using System.ComponentModel.DataAnnotations;

namespace Food_Order.Model
{
    public class Product
    {
      [Key]
     public int ProductId { get; set; }    
     [Required]
     [StringLength(100)]
     public string Name { get; set; }

     [Required]
     public decimal Price { get; set; }
    }
}

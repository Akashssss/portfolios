using System.ComponentModel.DataAnnotations;
using System.Data;

namespace Food_Order.Model
{
    public class Order
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public int CustomerId { get; set; } 

        [Required] 
        public DateTime OrderDate { get; set; }

        [Required]
        public Customer Customer { get; set; } 

        public ICollection<OrderProduct> OrderProducts { get; set; } 




    }
}
    
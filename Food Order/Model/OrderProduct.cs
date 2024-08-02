using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Food_Order.Model
{
    public class OrderProduct
    {

        [PrimaryKey, Column(Order = 0)]
        public int OrderId { get; set; }

        
        [PrimaryKey , Column(Order=1)]
        public int ProductId { get; set; }

        [Required]
        public int Quantity { get; set; } 


        public Order Order { get; set; } 
        public Product Product { get; set; } 


    }
}
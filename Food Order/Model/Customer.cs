using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Food_Order.Model
{
    public class Customer
    {
        [Key]
        public int Id { get; set; }


        [Required]
        [StringLength(50)]
        public string FirstName { get; set; }


        [Required]
        [StringLength (50)]
        public string LastName { get; set; }


        [Phone]
        [Required]
        public string Phone { get; set; }


        [EmailAddress]
        public string? Email { get; set; }
        public string? Address {  get; set; }


        public string CustomKey
        {
            get
            {
                // Combine the first 2 characters of FirstName and LastName
                string firstPart = FirstName.Length >= 2 ? FirstName.Substring(0, 2) : FirstName;
                string secondPart = LastName.Length >= 2 ? LastName.Substring(0, 2) : LastName;
                return firstPart + secondPart;
            }
        }

        public ICollection<Order> Orders { get; set; }


    }
}

using System.ComponentModel.DataAnnotations;

namespace ServerCS5.Models
{
    public class Account
    {
        [Key] public int Id { get; set; }
        [Required]
        [StringLength(25)]
        public string UserName { get; set; }
        [Required]
        [StringLength(50)]
        public string Email { get; set; }
        [Required]
        [StringLength(25)]
        public string Password { get; set; }
        [Required]
        [StringLength(10)]
        public string PhoneNumber { get; set; } 
        [Required]
        [StringLength(50)]
        public string FullName { get; set; }
        [Required]
        [StringLength(100)]
        public string Address { get; set; }
        [Required]
        public bool AccountType { get; set; } = false;


    }
}

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ServerCS5.Models
{
    public class Order
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [Column(TypeName = "decimal(10,2)")]
        public decimal Total { get; set; }
        public DateTime Time { get; set; } = DateTime.Now;
        public byte StatusOrder { get; set; } = 0;
        public byte StatusDelivery { get; set; } = 0;
        public byte PayMentMethod { get; set; } = 0;
        [ForeignKey("Account")]
        public int AccountId { get; set; }
        public Account Account { get; set; }

    }
}

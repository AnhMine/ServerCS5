using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ServerCS5.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(50)]
        public string Name { get; set; }
        [Required]
        [Column(TypeName ="decimal(10,2)")]
        public decimal Price { get; set; }
        [StringLength(10)]
        public string Hair { get; set; } 
        [StringLength(10)]
        public string Color { get; set; }
        [StringLength(10)]
        public string Popular { get; set; }
        [StringLength(5)]
        public string Size { get; set; }
        public bool Sex { get; set; } = false;
        [StringLength(10)]
        public string StatusHair { get; set; }
        [Required]
        [StringLength(15)]
        public string Status { get; set; }
        public byte Stock { get; set; }
        public string Description { get; set; } = string.Empty;
        [ForeignKey("Category")]
        public int CategoryId {  get; set; }
        public Category Category { get; set; }

    }
}

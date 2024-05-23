using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ServerCS5.Models
{
    public class Media
    {
        [Key]
        public int Id { get; set; }
        [ForeignKey("Product")]
        public int IdProduct { get; set; }
        public Product Product { get; set; }
        [ForeignKey("Image")]
        public int IdImage { get; set; }
        public Image Image { get; set; }
        public bool IsPrimary { get; set; }

    }
}

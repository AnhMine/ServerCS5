using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ServerCS5.Models
{
    public class Blog
    {
        [Key] public int Id { get; set; }
        [Required]
        [StringLength(100)]
        public string Headline { get; set; }
        public string Content { get; set; } = string.Empty;
        public DateTime DatePush { get; set; }
        public string Image { get; set; } = string.Empty;
        [ForeignKey("Account")]
        public int IdAccount { get; set; }
        public Account Account { get; set; }
    }
}

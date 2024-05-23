using System.ComponentModel.DataAnnotations;

namespace ServerCS5.Models
{
    public class Image
    {
        [Key]
        public int Id { get; set; }
        public string Link { get; set; }
    }
}

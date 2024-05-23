using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ServerCS5.DTOs
{
    public class ProductDTOs
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Hair { get; set; }
        public string Color { get; set; }
        public string Popular { get; set; }
        public string Size { get; set; }
        public bool Sex { get; set; } = false;
        public string StatusHair { get; set; }
        public string Description { get; set; } = string.Empty;
        public int IdCategory { get; set; }
        public string Link { get; set; }
       public string NameCategory { get; set; }
        public bool isPrimary { get; set; }

    }
}

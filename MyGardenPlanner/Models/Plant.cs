using System.ComponentModel.DataAnnotations.Schema;
using System.Xml.Linq;

namespace MyGardenPlanner.Models
{
    public class Plant
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("PlantIds")]
        public string Id { get; set; } = string.Empty;
        [Column("Name")]
        public string Name { get; set; } = string.Empty;
        [Column("CategoryId")]
        public string Category { get; set; } = string.Empty;
        [Column("Harvest")]
        public string? Harvest { get; set; }
        [Column("Height")]
        public string? Height { get; set; }

        [Column(TypeName = "decimal(6,2)")]
        public decimal InRowSpacing { get; set; }

        [Column(TypeName = "decimal(6,2)")]
        public decimal BetweenRowSpacing { get; set; }

    }
}

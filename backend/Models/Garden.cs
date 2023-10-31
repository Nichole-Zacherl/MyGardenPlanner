using System.ComponentModel.DataAnnotations.Schema;

namespace MyGardenPlanner.Models
{
    public class Garden
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("Id")]
        public string Id { get; set; } = string.Empty;
        [Column("Name")]
        public string Name { get; set; } = string.Empty;
        [Column("Description")]
        public string? Description { get; set; }
        [Column("Length")]
        public double Length { get; set; }
        [Column("Width")]
        public double Width { get; set; }
        //[Column("PlantIds")]
        //public ICollection<Plant>? Plants { get; set; }
    }
}

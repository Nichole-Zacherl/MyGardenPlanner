using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.InteropServices;

namespace MyGardenPlanner.Models
{
    public class PlantCategory
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string Id { get; set; } = string.Empty;
        public string Name { get; set; } = string.Empty;
    }
}

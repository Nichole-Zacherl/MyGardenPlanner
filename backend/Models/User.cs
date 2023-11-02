using System.ComponentModel.DataAnnotations.Schema;

namespace MyGardenPlanner.Models
{ 
    public class User
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("Id")]
        public string Id { get; set; } = string.Empty;
        [Column("UserName")]
        public string UserName { get; set; } = string.Empty;
        [Column("Password")]
        public string Password { get; set; } = string.Empty;
    }
}

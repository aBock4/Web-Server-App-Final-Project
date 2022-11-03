using System.ComponentModel.DataAnnotations;

namespace Web_Server_App_Final_Project.Models
{
    public class Trumpet
    {
        [Key]
        public int HornID { get; set; }
        public int Year { get; set; }
        public string? Model { get; set; }
        public string? Make { get; set; }

    }
}
using Microsoft.VisualBasic;
using System.ComponentModel.DataAnnotations;

namespace Web_Server_App_Final_Project.Models
{
    public class Cars
    {
        [Key]
        public int CarID { get; set; }
        public int? Year { get; set; }
        public string? Make { get; set; }
        public string? Model { get; set; }
        
    }
}

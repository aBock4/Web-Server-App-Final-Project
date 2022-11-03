using System.ComponentModel.DataAnnotations;

namespace Web_Server_App_Final_Project.Models
{
    public class Games
    {
        [Key]
        public int GameID { get; set; }
        public string? Name { get; set; }
        public string? Genre { get; set; }
        public string? Platform { get; set; }
        public int Year { get; set; }
    }
}

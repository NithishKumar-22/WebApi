using System.ComponentModel.DataAnnotations;
namespace Admin.Models

{
    public class User
    {
        [Key]
        public int UserID{get; set;}
        
        public string? Password{get; set;}
    }
}

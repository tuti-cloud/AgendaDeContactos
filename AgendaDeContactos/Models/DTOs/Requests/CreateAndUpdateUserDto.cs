using System.ComponentModel.DataAnnotations;

namespace AgendaDeContactos.Models.DTOs.Requests
{
    public class CreateAndUpdateUserDto
    {
        public string FirstName { get; set; } 
        public string LastName { get; set; } 
        public string Password { get; set; } 
        
        
        [EmailAddress]
        
        public string? Email { get; set; } 
    }
}

using AgendaDeContactos.Models.Enum;
using System.ComponentModel.DataAnnotations;

namespace AgendaDeContactos.Models.DTOs.Responses
{
    public class UserDto
    {
        private int id;
        private State state;

        public UserDto(int id, string firstName, string lastName, string email, State state)
        {
            this.id = id;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Email = email;
            this.state = state;
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Password { get; set; }
        [EmailAddress]
        [Required]
        public string Email { get; set; }
    }
}

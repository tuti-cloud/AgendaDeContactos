using AgendaDeContactos.Models.Enum;
using System.ComponentModel.DataAnnotations;

namespace AgendaDeContactos.Models.DTOs.Responses
{
    public class GetUserByIdDto
    {
        public GetUserByIdDto(int id, string firstName, string lastName, string email, string password, State state)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            Password = password;
            State = state;
        }

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Password { get; set; }
        [EmailAddress]
        [Required]
        public string Email { get; set; }

        public State State { get; set; }

    }
}

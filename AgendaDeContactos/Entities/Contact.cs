using System.ComponentModel.DataAnnotations.Schema;

namespace AgendaDeContactos.Entities
{
    public class Contact
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string? Address {  get; set; }
        public string? Number { get; set; }

        public string? Email { get; set; }
        public string? Image { get; set; }

        public string? Company { get; set; }

        public string Description { get; set; } = string.Empty;

        [ForeignKey("UserId")]
        public User User { get; set; }
        public int UserId { get; set; }
        public bool IsFavorite { get; set; } = false;

    }
}

using AgendaDeContactos.Entities;
using System.ComponentModel.DataAnnotations.Schema;

namespace AgendaDeContactos.Models.DTOs.Requests
{
    public class CreateAndUpdateContactDto
    {
    
        public string? FirstName { get; set; } = null;
        public string? LastName { get; set; } = null;
        public string? Address { get; set; } = null;
        public string? Number { get; set; } = null;

        public string? Email { get; set; } = null;
        public string? Image { get; set; } = null;

        public string? Company { get; set; } = null;

        public string Description { get; set; } = string.Empty;

    }
}


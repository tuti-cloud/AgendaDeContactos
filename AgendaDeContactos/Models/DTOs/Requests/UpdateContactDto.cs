namespace AgendaDeContactos.Models.DTOs.Requests
{
    public class UpdateContactDto
    {
        public string? FirstName { get; set; } 
        public string? LastName { get; set; } 
        public string? Address { get; set; } 
        public string? Number { get; set; } 

        public string? Email { get; set; } 
        public string? Image { get; set; } 

        public string? Company { get; set; } 

        public string? Description { get; set; } 
        public bool? IsFavorite { get; set; }
    }
}

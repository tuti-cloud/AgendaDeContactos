using AgendaDeContactos.Entities;
using System.ComponentModel.DataAnnotations.Schema;

namespace AgendaDeContactos.Models.DTOs.Responses
{
    public class ContactDto
    {
        public int Id { get; }
        public string FirstName { get; }
        public string LastName { get; }
        public string? Address { get; }
        public string? Number { get; }
        public string? Email { get; }
        public string? Image { get; }
        public string? Company { get; }
        public string Description { get; }
        public int UserId { get; }
        public bool IsFavorite { get; }

        public ContactDto(
            int id,
            string firstName,
            string lastName,
            string? address,
            string? number,
            string? email,
            string? image,
            string? company,
            string description,
            int userId,
            bool isFavorite)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            Address = address;
            Number = number;
            Email = email;
            Image = image;
            Company = company;
            Description = description;
            UserId = userId;
            IsFavorite = isFavorite;
        }

        public ContactDto(int id, string firstName, string lastName, string? address, string? number, string? email, string? image, string? company, string description, int userId, bool isFavorite, IEnumerable<Contact> enumerable) : this(id, firstName, lastName, address, number, email, image, company, description, userId, isFavorite)
        {
        }
    }
}

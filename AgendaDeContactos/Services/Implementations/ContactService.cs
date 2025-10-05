using AgendaDeContactos.Entities;
using AgendaDeContactos.Models.DTOs.Requests;
using AgendaDeContactos.Models.DTOs.Responses;
using AgendaDeContactos.Repositories.Implementations;
using AgendaDeContactos.Repositories.Interfaces;
using AgendaDeContactos.Services.Interfaces;

namespace AgendaDeContactos.Services.Implementations
{
    public class ContactService : IContactService

    {
        private readonly IContactRepository _contactRepository;
        public ContactService(IContactRepository contactRepository)

            
        {
            _contactRepository = contactRepository;
        }
 
                    public ContactDto Create(CreateAndUpdateContactDto dto, int loggedUserId)
        {
            Contact contact = new()
            {
                Email = dto.Email,
                Image = dto.Image,
                Number = dto.Number,
                Company = dto.Company,
                Address = dto.Address,
                LastName = dto.LastName,
                FirstName = dto.FirstName,
                UserId = loggedUserId,
                Description = dto.Description ?? "",
                IsFavorite = false
            };
            _contactRepository.Create(contact);

            return new ContactDto(
                contact.Id,
                contact.FirstName,
                contact.LastName,
                contact.Address,
                contact.Number,
                contact.Email,
                contact.Image,
                contact.Company,
                contact.Description,
                contact.UserId,
                contact.IsFavorite
            );
        }
        

        public void Delete(int id)
        {
            _contactRepository.Delete(id);
        }

        public List<ContactDto> GetAllByUser(int userid)
        {
            {
                return _contactRepository.GetAllByUser(userid).Select(contact => new ContactDto(
                    contact.Id,
                    contact.FirstName,
                    contact.LastName,
                    contact.Address,
                    contact.Number,
                    contact.Email,
                    contact.Image,
                    contact.Company,
                    contact.Description,
                    contact.UserId,
                    contact.IsFavorite,
                    _contactRepository.GetAllByUser(contact.Id)
                   )
                ).ToList();
            }
        }

public ContactDto? GetOneByUser(int userId, int contactId)
{
    var oneContact = _contactRepository.GetOneByUser(userId, contactId);
    if (oneContact == null)
        return null;

    return new ContactDto(
        oneContact.Id,
        oneContact.FirstName,
        oneContact.LastName,
        oneContact.Address,
        oneContact.Number,
        oneContact.Email,
        oneContact.Image,
        oneContact.Company,
        oneContact.Description,
        oneContact.UserId,
        oneContact.IsFavorite
    );
}




        public void Update(UpdateContactDto dto, int contactId)
        {
            var contact = _contactRepository.GetByContactId(contactId);
            if (contact is null) return;

            
            if (dto.FirstName is not null) contact.FirstName = dto.FirstName;
            if (dto.LastName is not null) contact.LastName = dto.LastName;
            if (dto.Address is not null) contact.Address = dto.Address;
            if (dto.Number is not null) contact.Number = dto.Number;
            if (dto.Email is not null) contact.Email = dto.Email;
            if (dto.Image is not null) contact.Image = dto.Image;
            if (dto.Company is not null) contact.Company = dto.Company;
            if (dto.Description is not null) contact.Description = dto.Description;
            if (dto.IsFavorite.HasValue) contact.IsFavorite = dto.IsFavorite.Value;

            _contactRepository.Update(contact, contactId);
        }
    }
    }


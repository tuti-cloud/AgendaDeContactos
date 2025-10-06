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
            Contact? contact = _contactRepository.GetByContactId(contactId);
            if (contact is not null) 

            {
                contact.FirstName = dto.FirstName;
            contact.LastName = dto.LastName;
                contact.Address = dto.Address;
                contact.Number = dto.Number;
                contact.Email = dto.Email;
            contact.Image = dto.Image;
                contact.Company = dto.Company;
                contact.Description = dto.Description;
                contact.IsFavorite = dto.IsFavorite.Value;
            }

            _contactRepository.Update(contact, contactId);
        }
    }
    }


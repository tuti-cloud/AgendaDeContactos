using AgendaDeContactos.Entities;
using AgendaDeContactos.Models.DTOs.Requests;
using AgendaDeContactos.Models.DTOs.Responses;

namespace AgendaDeContactos.Services.Interfaces
{
    public interface IContactService
    {
        ContactDto Create(CreateAndUpdateContactDto dto, int loggedUserid);

        void Delete(int id);

        List<ContactDto> GetAllByUser(int Userid );

        ContactDto? GetOneByUser(int userid, int contactId);

        void Update(UpdateContactDto dto, int Id);
        
    }
}

using AgendaDeContactos.Entities;

namespace AgendaDeContactos.Repositories.Interfaces
{
    public interface IContactRepository
    {
        int Create(Contact newContact);
        void Delete(int id);

        IEnumerable<Contact> GetAllByUser(int userid);

        Contact? GetByContactId(int contactid);
        Contact? GetOneByUser(int userid, int contactid);

        void Update(Contact updatedContact, int Id);
    }
}

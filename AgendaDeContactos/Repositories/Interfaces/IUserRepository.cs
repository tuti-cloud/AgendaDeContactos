using AgendaDeContactos.Entities;
using AgendaDeContactos.Models.DTOs.Responses;

namespace AgendaDeContactos.Repositories.Interfaces
{
    public interface IUserRepository
    {
        bool CheckIdUserExist(int userid);
        int Create(User newUser);
        List<User> GetAll();
        User? GetById (int userid);

        void RemoveUser(int userid);

        void Update(User updatedUser, int userid);
    }
}

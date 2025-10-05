using AgendaDeContactos.Entities;
using AgendaDeContactos.Models.DTOs.Requests;
using AgendaDeContactos.Models.DTOs.Responses;



namespace AgendaDeContactos.Services.Interfaces
{
    public interface IUserService
    {
        bool CheckifUserExist(int userId);

        UserDto Create(CreateAndUpdateUserDto dto);

        IEnumerable<UserDto> GetAll();

        GetUserByIdDto? GetById(int Userid);

        void RemoveUser(int  Userid);
        void Update(CreateAndUpdateUserDto dto ,int userid);


    }
}

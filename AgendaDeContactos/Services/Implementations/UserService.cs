using AgendaDeContactos.Entities;
using AgendaDeContactos.Models.DTOs.Requests;
using AgendaDeContactos.Models.DTOs.Responses;
using AgendaDeContactos.Repositories.Implementations;
using AgendaDeContactos.Repositories.Interfaces;
using AgendaDeContactos.Services.Interfaces;

namespace AgendaDeContactos.Services.Implementations
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;
        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public bool CheckifUserExist(int userId)
        {
            throw new NotImplementedException();
        }

        public UserDto Create(CreateAndUpdateUserDto dto)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<UserDto> GetAll()
        {
            return _userRepository.GetAll().Select(u => new UserDto(u.Id, u.FirstName, u.LastName, u.Email, u.State));
        }

        public GetUserByIdDto? GetById(int userId)
        {
            var user = _userRepository.GetById(userId);
            if (user is not null)
            {
                return new GetUserByIdDto(user.Id, user.FirstName, user.LastName, user.Email, user.Password, user.State);
            }
            return null;
        }
        public void RemoveUser(int Userid)
        {
            _userRepository.RemoveUser(Userid);
        }

        public void Update(CreateAndUpdateUserDto dto, int userid)
        {
            var user = _userRepository.GetById(userid);
            if (user is null) return;

            if (dto.FirstName is not null) user.FirstName = dto.FirstName;
            if (dto.FirstName is not null) user.FirstName = dto.FirstName;
            if (dto.FirstName is not null) user.FirstName = dto.FirstName;
            if (dto.FirstName is not null) user.FirstName = dto.FirstName;

            _userRepository.Update(user, userid);
        }

    }
}
    

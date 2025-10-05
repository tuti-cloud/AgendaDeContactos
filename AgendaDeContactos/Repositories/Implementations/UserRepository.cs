using AgendaDeContactos.Entities;
using AgendaDeContactos.Models.DTOs.Responses;
using AgendaDeContactos.Models.Enum;
using AgendaDeContactos.Repositories.Interfaces;

namespace AgendaDeContactos.Repositories.Implementations
{
    public class UserRepository : IUserRepository
    {
        
  
    
        public static List<User> Users = new List<User>
        {
            new User { Id = 1, FirstName = "Juan", LastName = "Pérez", Password = "1234", Email = "juan.perez@example.com", State = State.Active },
            new User { Id = 2, FirstName = "María", LastName = "Gómez", Password = "abcd", Email = "maria.gomez@example.com", State = State.Active },
            new User { Id = 3, FirstName = "Luis", LastName = "Fernández", Password = "pass1", Email = "luis.fernandez@example.com", State = State.Active },
            new User { Id = 4, FirstName = "Ana", LastName = "Martínez", Password = "pass2", Email = "ana.martinez@example.com", State = State.Active },
            new User { Id = 5, FirstName = "Carlos", LastName = "López", Password = "pass3", Email = "carlos.lopez@example.com", State = State.Active },
            new User { Id = 6, FirstName = "Laura", LastName = "Suárez", Password = "pass4", Email = "laura.suarez@example.com", State = State.Active },
            new User { Id = 7, FirstName = "Pedro", LastName = "Ramírez", Password = "pass5", Email = "pedro.ramirez@example.com", State = State.Active },
            new User { Id = 8, FirstName = "Lucía", LastName = "Torres", Password = "pass6", Email = "lucia.torres@example.com", State = State.Active }
        };
        
        
        
        
        
        public bool CheckIdUserExist(int userid)
        {
            throw new NotImplementedException();
        }

        public int Create(User newUser)
        {
            throw new NotImplementedException();
        }

        public List<User> GetAll()
        {
            return UserRepository.Users.ToList();
        }

        public User? GetById(int userId)
        {
            return Users.SingleOrDefault(u => u.Id == userId);
        }

        public void RemoveUser(int userid)
        {
            {
                var user = Users.FirstOrDefault(c => c.Id == userid);
                if (user != null)
                {
                    Users.Remove(user);
                }
            }
        }

        public void Update(User updatedUser, int userid)
        {
            User? user = Users.SingleOrDefault(user => user.Id == userid);
            if (user is not null)
            {
                user.Email = updatedUser.Email;
                user.LastName = updatedUser.LastName;
                user.FirstName = updatedUser.FirstName;
                user.Password = updatedUser.Password;

            }
            
        }
    }
}


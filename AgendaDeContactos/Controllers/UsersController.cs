using AgendaDeContactos.Models.DTOs.Requests;
using AgendaDeContactos.Models.DTOs.Responses;
using AgendaDeContactos.Repositories.Implementations;
using AgendaDeContactos.Repositories.Interfaces;
using AgendaDeContactos.Services.Implementations;
using AgendaDeContactos.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace AgendaDeContactos.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UsersController : ControllerBase
    {
        private readonly IUserService UserService;
        private readonly IUserRepository UserRepository;
        public UsersController(IUserService userService, IUserRepository userRepository)
        {
            UserService = userService;
            UserRepository = userRepository;
        }
        [HttpDelete]
        [Route("{userid}")]
        public IActionResult Delete(int userid)
        {
            UserService.RemoveUser(userid);
            return NoContent();
        }

        [HttpGet]

        public ActionResult<UserDto> GetAll()
        {
            return Ok(UserService.GetAll());
        }

        [HttpGet]
        [Route("{userid}")]

        public ActionResult<GetUserByIdDto> GetById(int userid)
        {
            return Ok(UserService.GetById(userid));
        }
    
         [HttpPut]
        [Route("userid")]

        public ActionResult UpdateUser(int userid, CreateAndUpdateUserDto dto)
        {
            if (dto == null) return BadRequest();

            UserService.Update(dto, userid);
            return NoContent();
        }
    }
}

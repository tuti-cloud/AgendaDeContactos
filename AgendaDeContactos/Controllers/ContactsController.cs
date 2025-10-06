using AgendaDeContactos.Entities;
using AgendaDeContactos.Models.DTOs.Requests;
using AgendaDeContactos.Models.DTOs.Responses;
using AgendaDeContactos.Services.Implementations;
using AgendaDeContactos.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Security.Cryptography.X509Certificates;

namespace AgendaDeContactos.Controllers
{

    public class ContactsController : ControllerBase

    {
        private readonly IContactService ContactService;
        public ContactsController(IContactService contactService)
        {
            ContactService = contactService;
        }
        [HttpDelete]
        [Route("{contactId}")]
        public IActionResult Delete(int contactId)
        {
            ContactService.Delete(contactId);
            return NoContent();
        }
        [HttpGet]
        [Route("{userid}")]
        public ActionResult<IEnumerable<ContactDto>> GetAllByUser(int userid)
        {
            var contacts = ContactService.GetAllByUser(userid);

            if (contacts == null || !contacts.Any())
                return NotFound($"No se encontraron contactos para el usuario con id {userid}.");

            return Ok(contacts);
        }

        [HttpGet("{userId}/contact/{contactId}")]
        public ActionResult<ContactDto> GetOneByUser(int userId, int contactId)
        {
            var contact = ContactService.GetOneByUser(userId, contactId);

            if (contact == null)
                return NotFound($"No se encontró contacto con id {contactId} para el usuario con id {userId}.");

            return Ok(contact);
        }

        [HttpPost]
        [Route("userid")]
        public ActionResult<ContactDto> CreateContact(int loggedUserId, CreateAndUpdateContactDto dto)
        {
            if (dto == null) return BadRequest("El cuerpo de la solicitud está vacío.");


            var created = ContactService.Create(dto, loggedUserId);


            return CreatedAtAction(nameof(GetOneByUser), new { userId = loggedUserId, contactId = created.Id }, created);
        }

        [HttpPut]
        [Route("{userid}")]
        public IActionResult UpdateContact(int id, UpdateContactDto dto)
        {
            if (dto == null) return BadRequest();

            ContactService.Update(dto, id);
            return NoContent();
        }


    }
}









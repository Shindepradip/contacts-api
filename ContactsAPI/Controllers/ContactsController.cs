using ContactsAPI.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using Evolent.Persistance;
using ContactsAPI.Services;
using System;
using Microsoft.AspNetCore.Authorization;

namespace ContactsAPI.Controllers
{
 
    [ApiController]
    [Route("[controller]")]
    [Produces("application/json")]
    public class ContactsController : ControllerBase
    {
        private readonly IContactService _service;

        public ContactsController(IContactService service)
        {
            _service = service;
        }

        [HttpGet]
        public IActionResult GetContacts()
        {
            var lst = _service.GetItems();

            return Ok(lst);
        }

        [HttpGet("{id}")]
        public IActionResult GetContacts(int id)
        {
            var lst = _service.GetItem(id);
            return Ok(lst);
        }

        [HttpPost]
        public IActionResult AddContact([FromBody] ContactsModel contact)
        {
            var result = _service.AddItem(contact);
            return Created("Created", result);
        }

        [HttpPut("{id}")]
        public IActionResult UpdateContact(int id, [FromBody] ContactsModel contact)
        {

            _service.Update(contact, id);

            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteContact(int id)
        {
            _service.Delete(id);

            return NoContent();
        }
    }
}

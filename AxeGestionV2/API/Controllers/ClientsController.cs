using AxeGestionV2.Application.Commands.ClientCommands;
using AxeGestionV2.Application.Queries.ClientQueries;
using AxeGestionV2.Domain.Models;
using MediatR;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace AxeGestionV2.API.Controllers
{
    [Route("api/client")]
    [ApiController]
    public class ClientsController : ControllerBase
    {
        private IMediator _mediator;

        public ClientsController(IMediator mediator)
        {
            _mediator = mediator;
        }

        // GET: api/<ClientController>
        [HttpGet]
        public async Task<List<Client>> ClientList()
        {
            var clientList = await _mediator.Send( new GetClientListQuery());
            return clientList;
        }

        // GET api/<ClientController>/5
        [HttpGet("{id}")]
        public async Task<Client> ClientById(int id)
        {
            var client = await _mediator.Send(new GetClientByIdQuery() { Id=id});
            return client;
        }

        // POST api/<ClientController>
        [HttpPost]
        public async Task<Client> AddClient(Client client)
        {
            var clientToAdd = await _mediator.Send(new CreateClientCommand(client.Name, client.Description));
            return clientToAdd;
        }

        // PUT api/<ClientController>/5
        [HttpPut]
        public async Task<int> UpdateClient(Client client)
        {
            var clientToUpdate = await _mediator.Send(new UpdateClientCommand(client.Id,client.Name, client.Description));
            return clientToUpdate;

        }

        // DELETE api/<ClientController>/5
        [HttpDelete("{id}")]
        public async Task<int> DeleteClient(int id)
        {
            var clientToDelete = await _mediator.Send(new DeleteClientCommand() { Id= id});
            return clientToDelete;

        }
    }
}

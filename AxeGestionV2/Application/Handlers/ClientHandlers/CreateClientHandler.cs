using AxeGestionV2.Application.Commands.ClientCommands;
using AxeGestionV2.Application.Services.ClientRepo;
using AxeGestionV2.Domain.Models;
using MediatR;

namespace AxeGestionV2.Application.Handlers.ClientHandlers
{
    public class CreateClientHandler : IRequestHandler<CreateClientCommand, Client>
    {
        private readonly IClientRepository _clientRepository;

        public CreateClientHandler(IClientRepository clientRepository)
        {
            _clientRepository = clientRepository;
        }
        public async Task<Client> Handle(CreateClientCommand request, CancellationToken cancellationToken)
        {
            Client client = new Client
            {
                Name = request.Name,
                Description = request.Description
        };
            return await _clientRepository.AddClientAsync(client);
        }
    }
}

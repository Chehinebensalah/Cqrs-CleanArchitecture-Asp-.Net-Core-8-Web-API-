using AxeGestionV2.Application.Commands.ClientCommands;
using AxeGestionV2.Application.Services.ClientRepo;
using MediatR;

namespace AxeGestionV2.Application.Handlers.ClientHandlers
{
    public class UpdateClientHandler : IRequestHandler<UpdateClientCommand, int>
    {
        private readonly IClientRepository _clientRepository;

        public UpdateClientHandler(IClientRepository clientRepository)
        {
            _clientRepository = clientRepository;
        }
        public async  Task<int> Handle(UpdateClientCommand request, CancellationToken cancellationToken)
        {
            var client = await _clientRepository.GetClientByIdAsync(request.Id);
            if (client == null) { 
                return default; 
            }
            client.Name = request.Name;
            client.Description = request.Description;
            return await _clientRepository.UpdateClientAsync(client);

        }
    }
}

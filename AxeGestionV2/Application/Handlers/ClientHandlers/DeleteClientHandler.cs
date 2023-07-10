using AxeGestionV2.Application.Commands.ClientCommands;
using AxeGestionV2.Application.Services.ClientRepo;
using MediatR;

namespace AxeGestionV2.Application.Handlers.ClientHandlers
{
    public class DeleteClientHandler : IRequestHandler<DeleteClientCommand, int>
    {
        private readonly IClientRepository _clientRepository;

        public DeleteClientHandler(IClientRepository clientRepository)
        {
            _clientRepository = clientRepository;
        }
        public async Task<int> Handle(DeleteClientCommand request, CancellationToken cancellationToken)
        {
            var client = await _clientRepository.GetClientByIdAsync(request.Id);
            if (client == null)
            {
                return default;
            }
            return await _clientRepository.DeleteClientAsync(request.Id);
        }
    }
}

using AxeGestionV2.Application.Queries.ClientQueries;
using AxeGestionV2.Application.Services.ClientRepo;
using AxeGestionV2.Domain.Models;
using MediatR;

namespace AxeGestionV2.Application.Handlers.ClientHandlers
{
    public class GetClientByIdHandler : IRequestHandler<GetClientByIdQuery, Client>
    {
        private readonly IClientRepository _clientRepository;

        public GetClientByIdHandler(IClientRepository clientRepository)
        {
            _clientRepository = clientRepository;
        }

        public async Task<Client> Handle(GetClientByIdQuery request, CancellationToken cancellationToken)
        {
            return await _clientRepository.GetClientByIdAsync(request.Id);
        }
    }
}

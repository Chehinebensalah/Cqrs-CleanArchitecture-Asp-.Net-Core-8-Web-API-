using AxeGestionV2.Application.Queries.ClientQueries;
using AxeGestionV2.Application.Services.ClientRepo;
using AxeGestionV2.Domain.Models;
using MediatR;

namespace AxeGestionV2.Application.Handlers.ClientHandlers
{
    public class GetClientListHandler : IRequestHandler<GetClientListQuery, List<Client>>
    {
        private readonly IClientRepository _clientRepository;

        public GetClientListHandler(IClientRepository clientRepository)
        {
            _clientRepository = clientRepository;
        }

        public async Task<List<Client>> Handle(GetClientListQuery request, CancellationToken cancellationToken)
        {
            return await _clientRepository.GetClientListAsync();
        }
    }
}

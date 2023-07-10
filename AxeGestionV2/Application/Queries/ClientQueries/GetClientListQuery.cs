using AxeGestionV2.Domain.Models;
using MediatR;

namespace AxeGestionV2.Application.Queries.ClientQueries
{
    public class GetClientListQuery :IRequest<List<Client>>
    {

    }
}

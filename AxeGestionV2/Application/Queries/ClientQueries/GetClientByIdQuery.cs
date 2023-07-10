using AxeGestionV2.Domain.Models;
using MediatR;

namespace AxeGestionV2.Application.Queries.ClientQueries
{
    public class GetClientByIdQuery : IRequest<Client>
    {
        public int Id{ get; set; } 
    }
}

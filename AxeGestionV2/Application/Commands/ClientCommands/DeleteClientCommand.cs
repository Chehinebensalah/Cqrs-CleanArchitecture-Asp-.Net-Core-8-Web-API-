using MediatR;

namespace AxeGestionV2.Application.Commands.ClientCommands
{
    public class DeleteClientCommand : IRequest<int>
    {
        public int Id{ get; set; }
    }
}

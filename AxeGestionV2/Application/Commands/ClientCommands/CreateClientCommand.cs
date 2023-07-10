using AxeGestionV2.Domain.Models;
using MediatR;

namespace AxeGestionV2.Application.Commands.ClientCommands
{
    public class CreateClientCommand : IRequest<Client>
    {
        public CreateClientCommand(String name, string description)
        {
            Name = name;
            Description = description;
        }

        public String Name { get; set; }
        public string Description { get; set; }
    }
}

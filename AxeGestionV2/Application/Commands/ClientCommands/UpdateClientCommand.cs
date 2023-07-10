using AxeGestionV2.Domain.Models;
using MediatR;

namespace AxeGestionV2.Application.Commands.ClientCommands
{
    public class UpdateClientCommand : IRequest<int>
    {
        public UpdateClientCommand(int id, String name, string description)
        {
            Id = id; 
            Name = name;
            Description = description;
        }
        public int  Id { get; set; }
        public String Name { get; set; }
        public string Description { get; set; }
    }
}

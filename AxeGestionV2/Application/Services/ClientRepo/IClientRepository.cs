using AxeGestionV2.Domain.Models;

namespace AxeGestionV2.Application.Services.ClientRepo
{
    public interface IClientRepository
    {
        public Task<List<Client>> GetClientListAsync();
        public Task<Client> GetClientByIdAsync(int id);
        public Task<Client> AddClientAsync(Client client);
        public Task<int> UpdateClientAsync(Client client);
        public Task<int> DeleteClientAsync(int id);
    }
}

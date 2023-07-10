using AxeGestionV2.Domain.Models;
using AxeGestionV2.Infrastructure.DataBase;
using Microsoft.EntityFrameworkCore;

namespace AxeGestionV2.Application.Services.ClientRepo
{
    public class ClientRepository : IClientRepository
    {
        private readonly DataContext _dbContext;

        public ClientRepository(DataContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<Client> AddClientAsync(Client client)
        {
            var result = _dbContext.clients.Add(client);
            await _dbContext.SaveChangesAsync();
            return result.Entity;
        }

        public async Task<int> DeleteClientAsync(int id)
        {
            var FilteredData = _dbContext.clients.Where(x =>x.Id == id).FirstOrDefault();
             _dbContext.clients.Remove(FilteredData);
            return await _dbContext.SaveChangesAsync();


        }

        public async Task<Client> GetClientByIdAsync(int id)
        {
            var FilteredData = await _dbContext.clients.Where(x => x.Id == id).FirstOrDefaultAsync();
            return FilteredData;
        }

        public async Task<List<Client>> GetClientListAsync()
        {
            var FilteredData = await _dbContext.clients.ToListAsync();
            return FilteredData;
        }

        public async Task<int> UpdateClientAsync(Client client)
        {
            _dbContext.clients.Update(client);
            return await _dbContext.SaveChangesAsync();
        }
    }
}

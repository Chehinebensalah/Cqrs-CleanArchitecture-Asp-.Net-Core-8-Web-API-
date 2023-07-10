using AxeGestionV2.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace AxeGestionV2.Infrastructure.DataBase
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }
        public DbSet<Client> clients { get; set; }
    }
}

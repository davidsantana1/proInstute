using DB.Domain.Entities;
using DB.Domain.Interfaces;
using DB.Persistence.Context;
using DB.Persistence.Repositories.Base;

namespace DB.Persistence.Repositories
{
    public class ClienteRepository : BaseRepository<Cliente>, IClienteRepository
    {
        public ClienteRepository(AppDbContext context)
            : base(context) { }

        // Métodos específicos para Cliente
        public async Task<Cliente> GetByEmailAsync(string email)
        {
            return await _context.Clientes.FirstOrDefaultAsync(c => c.Email == email);
        }
    }
}

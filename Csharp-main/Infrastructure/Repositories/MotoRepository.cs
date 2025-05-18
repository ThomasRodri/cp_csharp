using challenge_dotnet.Domain.Repositories;
using Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;
using challenge_dotnet.Domain.MotoRepository;

namespace challenge_dotnet.Infrastructure.Repositories
{
    public class MotoRepository : IMotoRepository
    {
        private readonly AppDbContext _context;

        public MotoRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Moto>> GetAllAsync()
        {
            return await _context.Motos.ToListAsync();
        }

        public async Task<Moto?> GetByIdAsync(int id)
        {
            return await _context.Motos.FindAsync(id);
        }

        public async Task AddAsync(Moto moto)
        {
            _context.Motos.Add(moto);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(Moto moto)
        {
            _context.Motos.Update(moto);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(Moto entity)
        {
            _context.Motos.Remove(entity);
            await _context.SaveChangesAsync();
        }

        public Task DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }
    }
}

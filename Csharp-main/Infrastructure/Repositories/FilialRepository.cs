using challenge_dotnet.Domain;
using Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repositories
{
    public class FilialRepository
    {
        private readonly AppDbContext _context;

        public FilialRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Filial>> GetAllAsync() =>
            await _context.Filiais.ToListAsync();

        public async Task<Filial> GetByIdAsync(int id)
        {
            var entity = await _context.Filiais.FindAsync(id);
            if (entity == null)
                throw new KeyNotFoundException($"Filial com id {id} não encontrada.");
            return entity;
        }


        public async Task AddAsync(Filial entity)
        {
            _context.Filiais.Add(entity);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(Filial entity)
        {
            _context.Filiais.Update(entity);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(Filial entity)
        {
            _context.Filiais.Remove(entity);
            await _context.SaveChangesAsync();
        }
    }
}

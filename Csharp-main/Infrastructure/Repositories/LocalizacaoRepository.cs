using Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repositories
{
    public class LocalizacaoRepository
    {
        private readonly AppDbContext _context;

        public LocalizacaoRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<LocalizacaoPatio>> GetAllAsync() =>
            await _context.Localizacoes.ToListAsync();

        public async Task<LocalizacaoPatio> GetByIdAsync(int id)
        {
            var entity = await _context.Localizacoes.FindAsync(id);
            if (entity == null) throw new KeyNotFoundException("Localização não encontrada.");
            return entity;
        }

        public async Task AddAsync(LocalizacaoPatio entity)
        {
            _context.Localizacoes.Add(entity);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(LocalizacaoPatio entity)
        {
            _context.Localizacoes.Update(entity);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(LocalizacaoPatio entity)
        {
            _context.Localizacoes.Remove(entity);
            await _context.SaveChangesAsync();
        }
    }
}

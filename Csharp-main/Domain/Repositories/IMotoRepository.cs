using challenge_dotnet.Domain.MotoRepository;

namespace challenge_dotnet.Domain.Repositories
{
    public interface IMotoRepository
    {
        Task<IEnumerable<Moto>> GetAllAsync();
        Task<Moto?> GetByIdAsync(int id);
        Task AddAsync(Moto moto);
        Task UpdateAsync(Moto moto);
        Task DeleteAsync(int id);
    }
}
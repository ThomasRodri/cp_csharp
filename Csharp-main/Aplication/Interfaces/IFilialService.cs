using challenge_dotnet.Aplication.DTOs;

namespace challenge_dotnet.Aplication.Interfaces
{
    public interface IFilialService
    {
        Task<IEnumerable<FilialDto>> GetAllAsync();
        Task<FilialDto> GetByIdAsync(int id);
        Task<FilialDto> CreateAsync(CreateFilialDto dto);
        Task<FilialDto> UpdateAsync(int id, UpdateFilialDto dto);
        Task<bool> DeleteAsync(int id);
    }
}

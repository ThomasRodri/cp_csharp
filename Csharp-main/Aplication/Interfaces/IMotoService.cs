using challenge_dotnet.Aplication.DTOs;

namespace challenge_dotnet.Aplication.Interfaces
{
    public interface IMotoService
    {
        Task<IEnumerable<MotoDto>> GetAllAsync();
        Task<MotoDto> GetByIdAsync(int id);
        Task<MotoDto> CreateAsync(CreateMotoDto dto);
        Task<MotoDto> UpdateAsync(int id, UpdateMotoDto dto);
        Task<bool> DeleteAsync(int id);
    }
}

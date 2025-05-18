using challenge_dotnet.Aplication.DTOs;

namespace challenge_dotnet.Aplication.Interfaces
{
    public interface ILocalizacaoService
    {
        Task<IEnumerable<LocalizacaoPatioDto>> GetAllAsync();
        Task<LocalizacaoPatioDto> GetByIdAsync(int id);
        Task<LocalizacaoPatioDto> CreateAsync(CreateLocalizacaoPatioDto dto);
        Task<LocalizacaoPatioDto> UpdateAsync(int id, UpdateLocalizacaoPatioDto dto);
        Task<bool> DeleteAsync(int id);
    }
}

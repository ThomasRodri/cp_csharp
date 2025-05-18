using challenge_dotnet.Aplication.DTOs;
using challenge_dotnet.Aplication.Interfaces;
using AutoMapper;
using challenge_dotnet.Domain;
using Infrastructure.Repositories;

namespace Application.Services
{
    public class LocalizacaoService : ILocalizacaoService
    {
        private readonly LocalizacaoRepository _repository;
        private readonly IMapper _mapper;

        public LocalizacaoService(LocalizacaoRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<IEnumerable<LocalizacaoPatioDto>> GetAllAsync()
        {
            var localizacoes = await _repository.GetAllAsync();
            return _mapper.Map<IEnumerable<LocalizacaoPatioDto>>(localizacoes);
        }

        public async Task<LocalizacaoPatioDto> GetByIdAsync(int id)
        {
            var localizacao = await _repository.GetByIdAsync(id);
            return _mapper.Map<LocalizacaoPatioDto>(localizacao);
        }

        public async Task<LocalizacaoPatioDto> CreateAsync(CreateLocalizacaoPatioDto dto)
        {
            var entity = _mapper.Map<LocalizacaoPatio>(dto);
            await _repository.AddAsync(entity);
            return _mapper.Map<LocalizacaoPatioDto>(entity);
        }

        public async Task<LocalizacaoPatioDto> UpdateAsync(int id, UpdateLocalizacaoPatioDto dto)
        {
            var entity = await _repository.GetByIdAsync(id);
            if (entity == null) throw new KeyNotFoundException("Localização não encontrada.");

            _mapper.Map(dto, entity);
            await _repository.UpdateAsync(entity);
            return _mapper.Map<LocalizacaoPatioDto>(entity);
        }

        public async Task<bool> DeleteAsync(int id)
        {
            var entity = await _repository.GetByIdAsync(id);
            if (entity == null) return false;

            await _repository.DeleteAsync(entity);
            return true;
        }
    }
}

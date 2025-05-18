using challenge_dotnet.Aplication.DTOs;
using challenge_dotnet.Aplication.Interfaces;
using AutoMapper;
using challenge_dotnet.Domain;
using Infrastructure.Repositories;

namespace Application.Services
{
    public class FilialService : IFilialService
    {
        private readonly FilialRepository _repository;
        private readonly IMapper _mapper;

        public FilialService(FilialRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<IEnumerable<FilialDto>> GetAllAsync()
        {
            var filiais = await _repository.GetAllAsync();
            return _mapper.Map<IEnumerable<FilialDto>>(filiais);
        }

        public async Task<FilialDto> GetByIdAsync(int id)
        {
            var filial = await _repository.GetByIdAsync(id);
            return _mapper.Map<FilialDto>(filial);
        }

        public async Task<FilialDto> CreateAsync(CreateFilialDto dto)
        {
            var entity = _mapper.Map<Filial>(dto);
            await _repository.AddAsync(entity);
            return _mapper.Map<FilialDto>(entity);
        }

        public async Task<FilialDto> UpdateAsync(int id, UpdateFilialDto dto)
        {
            var entity = await _repository.GetByIdAsync(id);
            if (entity == null) throw new KeyNotFoundException("Localização não encontrada.");

            _mapper.Map(dto, entity);
            await _repository.UpdateAsync(entity);
            return _mapper.Map<FilialDto>(entity);
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

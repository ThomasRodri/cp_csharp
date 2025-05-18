using challenge_dotnet.Aplication.DTOs;
using challenge_dotnet.Aplication.Interfaces;
using AutoMapper;
using challenge_dotnet.Domain.MotoRepository;
using challenge_dotnet.Infrastructure.Repositories;

namespace challenge_dotnet.Aplication.Services

{
    public class MotoService : IMotoService
    {
        private readonly MotoRepository _repository;
        private readonly IMapper _mapper;

        public MotoService(MotoRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<IEnumerable<MotoDto>> GetAllAsync()
        {
            var motos = await _repository.GetAllAsync();
            return _mapper.Map<IEnumerable<MotoDto>>(motos);
        }

        public async Task<MotoDto> GetByIdAsync(int id)
        {
            var moto = await _repository.GetByIdAsync(id);
            return _mapper.Map<MotoDto>(moto);
        }

        public async Task<MotoDto> CreateAsync(CreateMotoDto dto)
        {
            var entity = _mapper.Map<Moto>(dto);
            await _repository.AddAsync(entity);
            return _mapper.Map<MotoDto>(entity);
        }

        public async Task<MotoDto> UpdateAsync(int id, UpdateMotoDto dto)
        {
            var entity = await _repository.GetByIdAsync(id);
            if (entity == null) throw new KeyNotFoundException("Localização não encontrada.");

            _mapper.Map(dto, entity);
            await _repository.UpdateAsync(entity);
            return _mapper.Map<MotoDto>(entity);
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

using challenge_dotnet.Aplication.DTOs;
using Application.Services;
using Microsoft.AspNetCore.Mvc;

namespace Presentation.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class LocalizacoesController : ControllerBase
    {
        private readonly LocalizacaoService _localizacaoService;

        public LocalizacoesController(LocalizacaoService localizacaoService)
        {
            _localizacaoService = localizacaoService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var result = await _localizacaoService.GetAllAsync();
            return Ok(result);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var result = await _localizacaoService.GetByIdAsync(id);
            return result == null ? NotFound() : Ok(result);
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] CreateLocalizacaoPatioDto dto)
        {
            var created = await _localizacaoService.CreateAsync(dto);
            return CreatedAtAction(nameof(GetById), new { id = created.Id }, created);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, [FromBody] UpdateLocalizacaoPatioDto dto)
        {
            var updated = await _localizacaoService.UpdateAsync(id, dto);
            return updated == null ? NotFound() : Ok(updated);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await _localizacaoService.DeleteAsync(id);
            return NoContent();
        }
    }
}

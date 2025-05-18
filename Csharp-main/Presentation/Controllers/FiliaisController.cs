using challenge_dotnet.Aplication.DTOs;
using Application.Services;
using Microsoft.AspNetCore.Mvc;

namespace Presentation.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class FiliaisController : ControllerBase
    {
        private readonly FilialService _filialService;

        public FiliaisController(FilialService filialService)
        {
            _filialService = filialService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var result = await _filialService.GetAllAsync();
            return Ok(result);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var result = await _filialService.GetByIdAsync(id);
            return result == null ? NotFound() : Ok(result);
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] CreateFilialDto dto)
        {
            var created = await _filialService.CreateAsync(dto);
            return CreatedAtAction(nameof(GetById), new { id = created.Id }, created);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, [FromBody] UpdateFilialDto dto)
        {
            var updated = await _filialService.UpdateAsync(id, dto);
            return updated == null ? NotFound() : Ok(updated);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await _filialService.DeleteAsync(id);
            return NoContent();
        }
    }
}

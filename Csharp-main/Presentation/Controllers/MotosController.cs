using challenge_dotnet.Aplication.DTOs;
using challenge_dotnet.Aplication.Services;
using Microsoft.AspNetCore.Mvc;

namespace Presentation.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MotosController : ControllerBase
    {
        private readonly MotoService _motoService;

        public MotosController(MotoService motoService)
        {
            _motoService = motoService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var result = await _motoService.GetAllAsync();
            return Ok(result);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var result = await _motoService.GetByIdAsync(id);
            return result == null ? NotFound() : Ok(result);
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] CreateMotoDto dto)
        {
            var created = await _motoService.CreateAsync(dto);
            return CreatedAtAction(nameof(GetById), new { id = created.Id }, created);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, [FromBody] UpdateMotoDto dto)
        {
            var updated = await _motoService.UpdateAsync(id, dto);
            return updated == null ? NotFound() : Ok(updated);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await _motoService.DeleteAsync(id);
            return NoContent();
        }
    }
}

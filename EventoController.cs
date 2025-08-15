using Microsoft.AspNetCore.Mvc;
using EventiaSolutioN.Domain.Contracts;
using EventiaSolutioN.Domain.DTOs;

[ApiController]
[Route("api/eventos")] // ✅ Plural
public class EventosController : ControllerBase
{
    private readonly IEventoService _eventoService;

    public EventosController(IEventoService eventoService)
    {
        _eventoService = eventoService;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<EventoReadDto>>> GetAll()
    {
        var result = await _eventoService.GetAllAsync();
        return Ok(result); 
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<EventoReadDto>> GetById(int id)
    {
        var result = await _eventoService.GetByIdAsync(id);
        if (result == null) return NotFound();
        return Ok(result);
    }

    [HttpPost]
    public async Task<ActionResult<EventoReadDto>> Create(EventoCreateDto dto)
    {
        var result = await _eventoService.CreateAsync(dto);
        return CreatedAtAction(nameof(GetById), new { id = result.Id }, result);
    }

    [HttpPut("{id}")]
    public async Task<ActionResult<EventoReadDto>> Update(int id, EventoUpdateDto dto)
    {
        var result = await _eventoService.UpdateAsync(id, dto);
        if (result == null) return NotFound();
        return Ok(result);
    }

    [HttpDelete("{id}")]
    public async Task<ActionResult> Delete(int id)
    {
        var deleted = await _eventoService.DeleteAsync(id);
        if (!deleted) return NotFound();
        return NoContent();
    }
}


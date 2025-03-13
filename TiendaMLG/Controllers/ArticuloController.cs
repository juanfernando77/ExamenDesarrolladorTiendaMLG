using Microsoft.AspNetCore.Mvc;
using TiendaMLG.Business.DTOs;
using TiendaMLG.Business.Services;

namespace TiendaMLG.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ArticuloController : ControllerBase
    {
        private readonly ArticuloService _articuloService;

        public ArticuloController(ArticuloService articuloService)
        {
            _articuloService = articuloService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var articulos = await _articuloService.GetAll();
            return Ok(articulos);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var articulo = await _articuloService.GetById(id);
            if (articulo == null) return NotFound();
            return Ok(articulo);
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] ArticuloDto dto)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);

            var nuevoArticulo = await _articuloService.Create(dto);
            return CreatedAtAction(nameof(GetById), new { id = nuevoArticulo.ArticuloID }, nuevoArticulo);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, [FromBody] ArticuloDto dto)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);

            var actualizado = await _articuloService.Update(id, dto);
            if (!actualizado) return NotFound();

            return Ok(new { message = "Artículo actualizado correctamente" });
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var eliminado = await _articuloService.Delete(id);
            if (!eliminado) return NotFound();

            return Ok(new { message = "Artículo eliminado correctamente" });
        }
    }
}

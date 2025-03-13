using Microsoft.AspNetCore.Mvc;
using TiendaMLG.Business.Services;
using TiendaMLG.Entities.Models;
using TiendaMLG.Business.DTOs;
using System.Threading.Tasks;
using System.Collections.Generic;
using TiendaMLG.Business.DTOs;

namespace TiendaMLG.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TiendaController : ControllerBase
    {
        private readonly ClienteService _tiendaRepository;

        public TiendaController(ClienteService tiendaRepository)
        {
            _tiendaRepository = tiendaRepository;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var tiendas = await _tiendaRepository.ObtenerTiendasAsync();
            return Ok(tiendas);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var tienda = await _tiendaRepository.ObtenerTiendaPorIdAsync(id);
            if (tienda == null) return NotFound();
            return Ok(tienda);
        }

        
        [HttpPost]
        public async Task<IActionResult> Create([FromBody] TiendaDTO tiendaDto)
        {
            if (tiendaDto == null) return BadRequest("Datos inválidos");

            var tienda = new Tienda
            {
                Sucursal = tiendaDto.Sucursal,
                Direccion = tiendaDto.Direccion
            };

            var nuevaTienda = await _tiendaRepository.CrearTiendaAsync(tienda);
            return CreatedAtAction(nameof(GetById), new { id = nuevaTienda.TiendaID }, nuevaTienda);
        }
        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, [FromBody] TiendaDTO tiendaDto)
        {
            var tiendaExistente = await _tiendaRepository.ObtenerTiendaPorIdAsync(id);
            if (tiendaExistente == null) return NotFound();

            tiendaExistente.Sucursal = tiendaDto.Sucursal;
            tiendaExistente.Direccion = tiendaDto.Direccion;

            var actualizado = await _tiendaRepository.ActualizarTiendaAsync(tiendaExistente);
            if (!actualizado) return NotFound();

            return Ok(tiendaExistente);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var eliminado = await _tiendaRepository.EliminarTiendaAsync(id);
            if (!eliminado) return NotFound();
            return NoContent();
        }
    }
}
        
using Microsoft.AspNetCore.Mvc;
using TiendaMLG.Business.DTOs;
using TiendaMLG.Business.Services;
using TiendaMLG.Entities.Models;

namespace TiendaMLG.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientesController : ControllerBase
    {
        private readonly CienteService _clienteService;

        public ClientesController(CienteService clienteService)
        {
            _clienteService = clienteService;
        }

        [HttpGet]
        public async Task<IActionResult> GetClientes()
        {
            var clientes = await _clienteService.ObtenerClientes();
            return Ok(clientes);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetCliente(int id)
        {
            var cliente = await _clienteService.ObtenerClientePorId(id);
            if (cliente == null)
                return NotFound();

            return Ok(cliente);
        }

        [HttpPost]
        public async Task<IActionResult> PostCliente([FromBody] ClienteDto clienteDto)
        {
            if (clienteDto == null) return BadRequest("Datos inválidos");

            var cliente = new Cliente
            {
                Nombre = clienteDto.Nombre,
                Apellidos = clienteDto.Apellidos,
                Direccion = clienteDto.Direccion
            };

            var nuevoCliente = await _clienteService.AgregarCliente(cliente);

            return CreatedAtAction(nameof(GetCliente), new { id = nuevoCliente.ClienteID }, nuevoCliente);
        }


        [HttpPut("{id}")]
        public async Task<IActionResult> PutCliente(int id, [FromBody] ClienteDto clienteDto)
        {
            var clienteExistente = await _clienteService.ObtenerClientePorId(id);
            if (clienteExistente == null) return NotFound();

            clienteExistente.Nombre = clienteDto.Nombre;
            clienteExistente.Apellidos = clienteDto.Apellidos;
            clienteExistente.Direccion = clienteDto.Direccion;

            var actualizado = await _clienteService.ActualizarCliente(clienteExistente);
            if (!actualizado) return NotFound();

            return Ok(clienteExistente);
        }



        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCliente(int id)
        {
            var eliminado = await _clienteService.EliminarCliente(id);
            if (!eliminado)
                return NotFound();

            return NoContent();
        }
    }
}

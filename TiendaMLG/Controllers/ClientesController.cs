using Microsoft.AspNetCore.Mvc;
using TiendaMLG.Business.Services;
using TiendaMLG.Entities.Models;

namespace TiendaMLG.Controllers
{
    [ApiController]
        [Route("api/[controller]")]
    public class ClientesController : Controller
    {
        private readonly ClienteService _clienteService;

        public ClientesController(ClienteService clienteService)
        {
            _clienteService = clienteService;
        }

        [HttpGet]
        public async Task<ActionResult<List<Cliente>>> GetClientes()
        {
            return await _clienteService.ObtenerClientes();
        }

        [HttpPost]
        public async Task<ActionResult<Cliente>> PostCliente(Cliente cliente)
        {
            return await _clienteService.AgregarCliente(cliente);
        }
    }
}
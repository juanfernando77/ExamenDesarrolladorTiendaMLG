using TiendaMLG.Data.Contexts;
using TiendaMLG.Entities.Models;
using Microsoft.EntityFrameworkCore;

namespace TiendaMLG.Business.Services
{
    public class CienteService
    {
        private readonly ApplicationDbContext _context;

        public CienteService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<List<Cliente>> ObtenerClientes()
        {
            return await _context.Clientes.ToListAsync();
        }

        public async Task<Cliente?> ObtenerClientePorId(int id)
        {
            return await _context.Clientes.FindAsync(id);
        }

        public async Task<Cliente> AgregarCliente(Cliente cliente)
        {
            _context.Clientes.Add(cliente);
            await _context.SaveChangesAsync();
            return cliente; 
        }


        public async Task<bool> ActualizarCliente(Cliente cliente)
        {
            _context.Clientes.Update(cliente);
            return await _context.SaveChangesAsync() > 0;
        }


        public async Task<bool> EliminarCliente(int id)
        {
            var cliente = await _context.Clientes.FindAsync(id);
            if (cliente == null)
                return false;

            _context.Clientes.Remove(cliente);
            await _context.SaveChangesAsync();
            return true;
        }
    }
}

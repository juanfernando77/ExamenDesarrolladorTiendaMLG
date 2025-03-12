using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using TiendaMLG.Data.Contexts;
using TiendaMLG.Entities.Models;
using Microsoft.EntityFrameworkCore;


namespace TiendaMLG.Business.Services
{
    public class ClienteService
    {
        private readonly ApplicationDbContext _context;

        public ClienteService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<List<Tienda>> ObtenerTiendasAsync()
        {
            return await _context.Tiendas.ToListAsync();
        }

        public async Task<Tienda?> ObtenerTiendaPorIdAsync(int id)
        {
            return await _context.Tiendas.FindAsync(id);
        }

        public async Task<Tienda> CrearTiendaAsync(Tienda tienda)
        {
            _context.Tiendas.Add(tienda);
            await _context.SaveChangesAsync();
            return tienda;
        }

        public async Task<bool> ActualizarTiendaAsync(Tienda tienda)
        {
            // Buscar la tienda en la base de datos
            var tiendaExistente = await _context.Tiendas.FindAsync(tienda.TiendaID);

            // Si no se encuentra, retornar falso
            if (tiendaExistente == null)
                return false;

            // Actualizar solo los campos necesarios
            tiendaExistente.Sucursal = tienda.Sucursal;
            tiendaExistente.Direccion = tienda.Direccion;

            return await _context.SaveChangesAsync() > 0;
        }


        public async Task<bool> EliminarTiendaAsync(int id)
        {
            var tienda = await _context.Tiendas.FindAsync(id);
            if (tienda == null) return false;

            _context.Tiendas.Remove(tienda);
            return await _context.SaveChangesAsync() > 0;
        }

        public async Task<List<Cliente>> ObtenerClientes()
        {
            return await _context.Clientes.ToListAsync();
        }

        public async Task<Cliente> AgregarCliente(Cliente cliente)
        {
            _context.Clientes.Add(cliente);
            await _context.SaveChangesAsync();
            return cliente;
        }
    }
}

using Microsoft.EntityFrameworkCore;
using TiendaMLG.Business.DTOs;
using TiendaMLG.Data.Contexts;
using TiendaMLG.Entities.Models;

namespace TiendaMLG.Business.Services
{
    public class ArticuloService
    {
        private readonly ApplicationDbContext _context;

        public ArticuloService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Articulo>> GetAll()
        {
            return await _context.Articulos.ToListAsync();
        }

        public async Task<Articulo> GetById(int id)
        {
            return await _context.Articulos.FindAsync(id);
        }

        public async Task<Articulo> Create(ArticuloDto dto)
        {
            var articulo = new Articulo
            {
                Codigo = dto.Codigo,
                Descripcion = dto.Descripcion,
                Precio = dto.Precio,
                Imagen = dto.Imagen,
                Stock = dto.Stock
            };

            _context.Articulos.Add(articulo);
            await _context.SaveChangesAsync();
            return articulo;
        }

        public async Task<bool> Update(int id, ArticuloDto dto)
        {
            var articulo = await _context.Articulos.FindAsync(id);
            if (articulo == null) return false;

            articulo.Codigo = dto.Codigo;
            articulo.Descripcion = dto.Descripcion;
            articulo.Precio = dto.Precio;
            articulo.Imagen = dto.Imagen;
            articulo.Stock = dto.Stock;

            await _context.SaveChangesAsync();
            return true;
        }

        public async Task<bool> Delete(int id)
        {
            var articulo = await _context.Articulos.FindAsync(id);
            if (articulo == null) return false;

            _context.Articulos.Remove(articulo);
            await _context.SaveChangesAsync();
            return true;
        }
    }
}

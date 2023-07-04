using Microsoft.EntityFrameworkCore;
using PrestaFacil.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PrestaFacil.Services
{
    public interface ITipoTransaccionService
    {
        Task<List<Tipo_transaccion>> Get();
        Tipo_transaccion Get(int id);
    }

    public class TipoTransaccionService : ITipoTransaccionService
    {
        private readonly ApplicationDbContext _context;

        public TipoTransaccionService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<List<Tipo_transaccion>> Get()
        {
            return await _context.Tipo_transaccion.ToListAsync();
        }

        public Tipo_transaccion Get(int id)
        {
            return _context.Tipo_transaccion.Find(id);
        }

        
    }
}

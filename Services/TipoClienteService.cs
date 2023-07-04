using PrestaFacil.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;
using System;

namespace PrestaFacil.Services
{
    public interface ITipoClienteService
    {
        Task<List<Tipo_Cliente>> GetTiposClientes();
    }


    public class TipoClienteService : ITipoClienteService
    {
        private readonly ApplicationDbContext _context;
        public TipoClienteService(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<List<Tipo_Cliente>> GetTiposClientes()
        {
                return await _context.Tipo_Cliente.ToListAsync();

        }
    }
}

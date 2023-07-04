using Microsoft.EntityFrameworkCore;
using PrestaFacil.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PrestaFacil.Services
{
    public interface ICobradorService
    {
        Task<List<Cobrador>> Get();
    }

    public class CobradorService : ICobradorService
    {
        private readonly ApplicationDbContext _context;
        public CobradorService(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<List<Cobrador>> Get()
        {
              
            return await _context.Cobrador.ToListAsync(); 
        }
    }
}
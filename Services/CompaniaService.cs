using PrestaFacil.Models;
using PrestaFacil;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;
using System.Reflection.Metadata;
using System.Security.Cryptography.X509Certificates;
using static System.Net.Mime.MediaTypeNames;
using System.ComponentModel;

namespace PrestaFacil.Services
{
    public interface ICompaniaService
    {
        Task<List<Compania>> Get();
        Task<List<Compania>> GetAll();
        Task<Compania> Get(int id);
        Task<Compania> Add(Compania Compania);
        Task<Compania> Update(Compania Compania);
        Task<Compania> Delete(int id);
    }
    public class CompaniaService : ICompaniaService
    {
        private readonly ApplicationDbContext _context;

        public CompaniaService(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<List<Compania>> Get()
        {
            //--DataContext.example.AsNoTracking().ToList();
            //var cia = await _context.Compania.AsNoTracking().ToListAsync();
            //var cia = await _context.Compania.ToListAsync();
            //await _context.Entry(cia).ReloadAsync();
            //await _context.Entry(Compania).ReloadAsync();
            return await _context.Compania.ToListAsync();
        }
        public async Task<List<Compania>> GetAll()
        {
            List<Compania> vcia = new List<Compania>();

            await _context.Entry(vcia).ReloadAsync();

            return vcia;
        }

        public async Task<Compania> Get(int id)
        {
            //FindByIdAsync(id, forceRefresh: true);
            //Compania cia = await _context.Compania.FindByIdAsync(id, forceRefresh: true);
            return await _context.Compania.Where(x => x.Id == id).FirstAsync();
            
        }

        public async Task<Compania> Add(Compania Compania)
        {
            _context.Compania.Add(Compania);
            await _context.SaveChangesAsync();
            return Compania;
        }

        public async Task<Compania> Update(Compania Compania)
        {
            Compania cia = new Compania();
            cia = Compania;
            _context.Entry(cia).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return Compania;
        }

        public async Task<Compania> Delete(int id)
        {
            var Compania = await _context.Compania.FindAsync(id);
            _context.Compania.Remove(Compania);
            await _context.SaveChangesAsync();
            return Compania;
        }
    }
}
using PrestaFacil.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;
using System;


namespace PrestaFacil.Services
{
    public interface IClienteService
    {
        Task<List<Cliente>> Get();
        Task<List<Cliente>> GetAll();
        List<Cliente> GetAllEsp();
        Task<Cliente> Get(int id);
        Task<Cliente> Add(Cliente Cliente);
        Task<Cliente> Update(Cliente Cliente);
        Task<Cliente> Delete(int id);
        
    }
    public class ClienteService : IClienteService
    {
        private readonly ApplicationDbContext _context;

        public ClienteService(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<List<Cliente>> Get()
        {
               return await _context.Cliente.ToListAsync();
        }
        public async Task<List<Cliente>> GetAll()
        {
            List<Cliente> vcia = new List<Cliente>();

            await _context.Entry(vcia).ReloadAsync();

            return vcia;
        }

        public async Task<Cliente> Get(int id)
        {
            return await _context.Cliente.Where(x => x.Id == id).FirstAsync();
        }

        public async Task<Cliente> Add(Cliente Cliente)
        {
            _context.Cliente.Add(Cliente);
            await _context.SaveChangesAsync();
            return Cliente;
        }

        public async Task<Cliente> Update(Cliente Cliente)
        {
            Cliente cliente = new Cliente();
            cliente = Cliente;
            _context.Entry(cliente).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return cliente;
        }

        public async Task<Cliente> Delete(int id)
        {
            var Cliente = await _context.Cliente.FindAsync(id);
            _context.Cliente.Remove(Cliente);
            await _context.SaveChangesAsync();
            return Cliente;
        }

        public List<Cliente> GetAllEsp()
        {
            return _context.Cliente.ToList();
        }
    }
}
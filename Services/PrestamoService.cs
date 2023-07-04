using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PrestaFacil.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Dynamic.Core;
using System.Threading.Tasks;
using System.Transactions;

namespace PrestaFacil.Services
{
        public interface IPrestamoService
        {
            Task<List<Prestamo>> Get();
            Task<List<Prestamo>> GetAll();
            List<Prestamo> GetAllEsp();
            Task<Prestamo> Get(int id);
            Task<Prestamo> Add(Prestamo Prestamo);
            Task<Prestamo> Update(Prestamo Prestamo);
            Task<Prestamo> Delete(int id);
        List<VwPrestamosClientes> lstPrestamosClientes(int pClietneId);

        }

        public class PrestamoService : IPrestamoService
        {
            private readonly ApplicationDbContext _context;

            public PrestamoService(ApplicationDbContext context)
            {
                _context = context;
            }
            public async Task<List<Prestamo>> Get()
            {
                List<Prestamo> vlstPrestamo = new List<Prestamo>();
            vlstPrestamo = await _context.Prestamo.ToListAsync();
                return vlstPrestamo;


            }
            public async Task<List<Prestamo>> GetAll()
            {
                List<Prestamo> lstPrestamos = new List<Prestamo>();

                await _context.Entry(lstPrestamos).ReloadAsync();

                return lstPrestamos;
            }

            public async Task<Prestamo> Get(int id)
            {
                return await _context.Prestamo.Where(x => x.Id == id).FirstAsync();
            }

            public async Task<Prestamo> Add(Prestamo Prestamo)
            {
                try 
                {
                    _context.Prestamo.Add(Prestamo);
                    await _context.SaveChangesAsync();
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
                
                return Prestamo;
            }

            public async Task<Prestamo> Update(Prestamo pprestamo)
            {
                Prestamo prestamo = new Prestamo();
                prestamo = pprestamo;
                _context.Entry(prestamo).State = EntityState.Modified;
                await _context.SaveChangesAsync();
                return prestamo;
            }

            public async Task<Prestamo> Delete(int id)
            {
                var Prestamo = await _context.Prestamo.FindAsync(id);
                _context.Prestamo.Remove(Prestamo);
                await _context.SaveChangesAsync();
                return Prestamo;
            }

            public List<Prestamo> GetAllEsp()
            {
                return _context.Prestamo.ToList();
            }

        public List<VwPrestamosClientes> lstPrestamosClientes(int pClietneId)
        {
            List<VwPrestamosClientes> lstPrestamoCliente = new List<VwPrestamosClientes>();
            
            if (_context.VwPrestamosClientes.Count()  != 0)
            {
                lstPrestamoCliente = _context.VwPrestamosClientes.Where(x => x.ClienteId == pClietneId).ToList();
            }
            
            return lstPrestamoCliente;
            
        }

        //public IEnumerable<VwPrestamosClientes> lstPrestamosClientes( int pClietneId)
        //{
        //    var lstPrestamo = (from e in _context.Prestamo
        //                       join d in _context.Cliente on e.ClienteId equals d.Id
        //                       select new VwPrestamosClientes
        //                       {
        //                           PrestamoId = e.Id,
        //                           ClienteId = e.ClienteId,
        //                           Nombre_cliente = d.Nombre,
        //                           Monto_prestamo = e.Monto_prestamo,
        //                           tasa =  e.Tasa,
        //                           Cantidad_cuota = e.Cantidad_cuota
        //                       }).ToList().Where(x => x.ClienteId == pClietneId).ToList();

        //    return lstPrestamo;

        //}
    }
    
}

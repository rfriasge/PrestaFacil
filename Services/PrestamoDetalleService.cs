using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;
using Microsoft.EntityFrameworkCore.Query.SqlExpressions;
using PrestaFacil.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using static PrestaFacil.Services.PrestamoService;

namespace PrestaFacil.Services
{
   
        public interface IPrestamoDetalleService
        {
            Task<List<Prestamo_Detalle>> Get();
            Task<List<VwPrestamosClientes>> GetPrestamoCliente(int Id);
            List<VwClientePrestamoDetalle> GetPrestamoDetalleCliente(int Id);
            VwClientePrestamoDetalle GetPrestamoCuota(int pPrestamoId, int pNoCuota);
        Task<List<Prestamo_Detalle>> GetAll();
            List<Prestamo_Detalle> GetAllEsp();
            Task<Prestamo_Detalle> Get(int id);
            Task<Prestamo_Detalle> Add(Prestamo_Detalle PrestamoDetalle);
            Task<Prestamo_Detalle> Update(Prestamo_Detalle PrestamoDetalle);
            Task<Prestamo_Detalle> Delete(int id);

        }
        public class PrestamoDetalleService : IPrestamoDetalleService
    {
            private readonly ApplicationDbContext _context;

            public PrestamoDetalleService(ApplicationDbContext context)
            {
                _context = context;
            }
            public async Task<List<Prestamo_Detalle>> Get()
            {
                return await _context.Prestamo_Detalle.ToListAsync();
            }
            public async Task<List<Prestamo_Detalle>> GetAll()
            {
                List<Prestamo_Detalle> vcia = new List<Prestamo_Detalle>();

                await _context.Entry(vcia).ReloadAsync();

                return vcia;
            }

            public async Task<Prestamo_Detalle> Get(int id)
            {
                return await _context.Prestamo_Detalle.Where(x => x.Id == id).FirstAsync();
            }

            public async Task<Prestamo_Detalle> Add(Prestamo_Detalle prestamoDetalle)
            {
                try
                {
                    _context.Prestamo_Detalle.Add(prestamoDetalle);
                    await _context.SaveChangesAsync();
                }
                catch(Exception e){
                Console.WriteLine(e.Message);
                }

                return prestamoDetalle;
            }

            public async Task<Prestamo_Detalle> Update(Prestamo_Detalle pprestamoDetalle)
            {
                Prestamo_Detalle prestamoDetalle = new Prestamo_Detalle();
                prestamoDetalle = pprestamoDetalle;
                _context.Entry(prestamoDetalle).State = EntityState.Modified;
                await _context.SaveChangesAsync();
                return prestamoDetalle;
            }

            public async Task<Prestamo_Detalle> Delete(int id)
            {
                var Prestamo_Detalle = await _context.Prestamo_Detalle.FindAsync(id);
                _context.Prestamo_Detalle.Remove(Prestamo_Detalle);
                await _context.SaveChangesAsync();
                return Prestamo_Detalle;
            }

            public List<Prestamo_Detalle> GetAllEsp()
            {
                return _context.Prestamo_Detalle.ToList();
            }

        public async Task<List<VwPrestamosClientes>> GetPrestamoCliente(int pClienteId)
        {
            List<VwPrestamosClientes> lstPrestamosClientes = new List<VwPrestamosClientes>();
            lstPrestamosClientes =  await _context.VwPrestamosClientes.Where(x=>x.ClienteId == pClienteId).ToListAsync();
            return lstPrestamosClientes;


        }

        public List<VwClientePrestamoDetalle> GetPrestamoDetalleCliente(int pClienteId)
        {

            List<VwClientePrestamoDetalle> lstClientePrestamoDetalle = new List<VwClientePrestamoDetalle>();

            if (_context.VwClientePrestamoDetalle.Count() != 0)
            {
                lstClientePrestamoDetalle = _context.VwClientePrestamoDetalle.Where(x => x.ClienteId == pClienteId).ToList();
            }

            return lstClientePrestamoDetalle;

            

        }

        public VwClientePrestamoDetalle GetPrestamoCuota(int pPrestamoId, int pNoCuota)
        {
            VwClientePrestamoDetalle clientePrestamoDetalle = new VwClientePrestamoDetalle();

            if (_context.VwClientePrestamoDetalle.Count() != 0)
            {
                clientePrestamoDetalle = _context.VwClientePrestamoDetalle.Where(x => x.PrestamoId == pPrestamoId && x.NoCuota == pNoCuota).FirstOrDefault();
            }

            return clientePrestamoDetalle;
        }


    }
   
}

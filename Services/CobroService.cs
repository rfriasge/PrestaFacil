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
    public interface ICobroService
    {
        Task<List<Cobro_cabecera>> Get();
        Task<List<Cobro_cabecera>> GetAll();
        List<Cobro_cabecera> GetAllEsp();
        Task<Cobro_cabecera> Get(int id);
        Task<Cobro_cabecera> Add(Cobro_cabecera Cobro_cabecera);
        Task<Cobro_cabecera> Update(Cobro_cabecera Cobro_cabecera);
        Task<Cobro_cabecera> Delete(int id);
        Cobro_detalle getcuota(int PrestamoId, int pNoCuota, int pTipoTransaccionId);
        

    }

    public class CobroService : ICobroService
    {
        private readonly ApplicationDbContext _context;

        public CobroService(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<List<Cobro_cabecera>> Get()
        {
            return await _context.Cobro_cabecera.ToListAsync();
        }
        public async Task<List<Cobro_cabecera>> GetAll()
        {
            List<Cobro_cabecera> lstCobro_cabecera = new List<Cobro_cabecera>();

            await _context.Entry(lstCobro_cabecera).ReloadAsync();

            return lstCobro_cabecera;
        }

        public async Task<Cobro_cabecera> Get(int id)
        {
            return await _context.Cobro_cabecera.Where(x => x.Id == id).FirstAsync();
        }

        public async Task<Cobro_cabecera> Add(Cobro_cabecera Cobro_cabecera)
        {
            //var cd = Cobro_cabecera.cobro_detalle;
            //List<vCobroDetalle> lstvcd = new List<vCobroDetalle>();

            //for (int i = 0; i <= Cobro_cabecera.cobro_detalle.Count; i++)
            //{
            //    vCobroDetalle ccd = new vCobroDetalle();
            //    ccd.NoCuota = Cobro_cabecera.cobro_detalle[i].NoCuota;
            //    ccd.Cuota   = Cobro_cabecera.cobro_detalle[i].Cuota;
            //    ccd.PrestamoId = Cobro_cabecera.cobro_detalle[i].PrestamoId;
            //    ccd.Tipo_transaccionId = Cobro_cabecera.cobro_detalle[i].Tipo_transaccionId;
            //    lstvcd.Add(ccd);
            //}
            //Cobro_cabecera.cobro_detalle = lstvcd;
            try
            {

                _context.Cobro_cabecera.Add(Cobro_cabecera);
                await _context.SaveChangesAsync();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            return Cobro_cabecera;
        }

        public async Task<Cobro_cabecera> Update(Cobro_cabecera Cobro_cabecera)
        {
            Cobro_cabecera cobro_cabecera = new Cobro_cabecera();
            cobro_cabecera = Cobro_cabecera;
            _context.Entry(Cobro_cabecera).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return Cobro_cabecera;
        }

        public async Task<Cobro_cabecera> Delete(int id)
        {
            var Cobro_cabecera = await _context.Cobro_cabecera.FindAsync(id);
            _context.Cobro_cabecera.Remove(Cobro_cabecera);
            await _context.SaveChangesAsync();
            return Cobro_cabecera;
        }

        public List<Cobro_cabecera> GetAllEsp()
        {
            return _context.Cobro_cabecera.ToList();
        }

        public Cobro_detalle getcuota(int PrestamoId, int pNoCuota, int pTipoTransaccionId)
        {
            //var CobDetCuota = _context.Cobro_cabecera.co
            Cobro_detalle cb = new Cobro_detalle();
            cb = _context.Cobro_detalle.Where(x=>x.PrestamoId == PrestamoId && x.NoCuota == pNoCuota && x.Tipo_transaccionId == pTipoTransaccionId).FirstOrDefault(); 
            return cb;
        }
    }

}

using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.SignalR;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic;
using PrestaFacil.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PrestaFacil.Services
{
    public interface IAmortizacion
    {
            Task<TablaAmortizacion> Add(TablaAmortizacion TablaAmortizacion);
            Task  DeleteAll();
            Task<List<TablaAmortizacion>> GetAllAmortizacion();

        
        

    }
    public class AmortizacionService : IAmortizacion
    {
        private readonly ApplicationDbContext _context;

        public AmortizacionService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<TablaAmortizacion> Add(TablaAmortizacion TablaAmortizacion)
        {
            
            try
            {
                _context.TablaAmortizacion.Add(TablaAmortizacion);
                await _context.SaveChangesAsync();
            }catch(SqlException e)
            {
                var mensage = e.Message;
            }
            
            return TablaAmortizacion;
        }

        public async Task DeleteAll()
        {
            int TotalRegBorrados = _context.Database.ExecuteSqlCommand("DELETE FROM TablaAmortizacion");
            //_context.Database.ExecuteSqlCommand("TRUNCATE TABLE [TablaAmortizacion]");
            await _context.SaveChangesAsync();
            
        }



        public async Task<List<TablaAmortizacion>> GetAllAmortizacion()
        {
            return await _context.TablaAmortizacion.ToListAsync();
        }

        
    }

    
}


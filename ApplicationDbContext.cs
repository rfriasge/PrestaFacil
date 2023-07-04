using PrestaFacil.Models;
using Microsoft.EntityFrameworkCore;
using System;

namespace PrestaFacil
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Compania> Compania{ get; set; }
        public DbSet<Cliente> Cliente { get; set; }
        public DbSet<Tipo_Cliente> Tipo_Cliente { get; set;}
        public DbSet<TablaAmortizacion> TablaAmortizacion { get; set; }
        public DbSet<Prestamo> Prestamo { get; set; }
        public DbSet<Prestamo_Detalle> Prestamo_Detalle { get; set; }
        public DbSet<Cobro_cabecera> Cobro_cabecera { get; set; }
        public  DbSet<Cobro_detalle> Cobro_detalle { get; set; }
        public DbSet<Cobrador> Cobrador { get; set; }
        public DbSet<Tipo_transaccion> Tipo_transaccion { get; set; }

        public virtual DbSet<VwPrestamosClientes> VwPrestamosClientes { get; set; }

        public virtual DbSet<VwClientePrestamoDetalle> VwClientePrestamoDetalle { get; set; }

    }
}

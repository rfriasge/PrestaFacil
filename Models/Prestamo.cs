using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace PrestaFacil.Models
{
    public class Prestamo
    {
        public int Id { get; set; }
        public int ClienteId { get; set; }
        public int Tipo_prestamoId { get; set; }
        
        public DateTime? Fecha_prestamo { get; set; }
        public int Ultima_cuota_pagada { get; set; }
        
        public DateTime? Fecha_ultimo_pago { get; set; }
        public decimal Monto_prestamo { get; set; }
        public decimal Tasa { get; set; }
        public int Cantidad_cuota { get; set; }
        public string Usrcre { get; set; }
        
        public DateTime? Feccre { get; set; }
        public string Usrmod { get; set; }
        public DateTime? fecMod { get; set; }
        public int Estado { get; set; }
        public List<Prestamo_Detalle> Prestamo_Detalles { get; set; }
    }
}

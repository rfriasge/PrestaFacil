using System;
using System.Collections.Generic;

namespace PrestaFacil.Models
{
    public class Cobro_cabecera
    {
        public int Id { get; set; }
        public DateTime Fecha { get; set; }
        public int Estado { get; set; }
        public int ClienteId { get; set; }
        public string Concepto { get; set; }
        public string Usrcre { get; set; }
        public DateTime Feccre { get; set; }
        public string Usrmod { get; set; }
        public DateTime Fecmod { get; set; }
        public List<Cobro_detalle> cobro_detalle { get; set; }
    }

   
}

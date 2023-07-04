using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PrestaFacil.Models
{
    
    public class Cliente
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "El Campo {0} es obligatorio")]
        public string Nombre { get; set; }
        //[Range(1, 2, ErrorMessage = "El campo es obligatorio")]
        //[Required(ErrorMessage = "El Campo {0} es obligatorio")]
        public int Tipo_clienteId { get; set; }
        public Tipo_Cliente Tipo_Cliente { get; set; }
        [Required(ErrorMessage = "El Campo {0} es obligatorio")]
        public string Rnc_cedula { get; set; }
        [Required(ErrorMessage = "El Campo {0} es obligatorio")]
        public string Direccion { get; set; }
        public string Telefono1 { get; set; }
        public string Telefono2 { get; set; }
        public string Email { get; set; }
        public string Contacto { get; set; }
        public string Telefono_contacto { get; set; }
        public string Usrcre { get; set; }
        public DateTime Feccre { get; set; }
        public string Usrmod { get; set; }
        public DateTime Fecmod { get; set; }
        
    }
}

using System;
using System.ComponentModel.DataAnnotations;

namespace PrestaFacil.Models
{
    public class Compania
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "El Campo {0} es obligatorio")]
        public string Nombre { get; set; }
        [Required(ErrorMessage = "El Campo {0} es obligatorio")]
        public string Direccion { get; set; }
        [Required(ErrorMessage = "El Campo {0} es obligatorio")]
        public string Rnc { get; set; }
        public string Telefono1 { get; set; }
        public string Telefono2 { get; set; }
        public string Email { get; set; }
        public string Contacto { get; set; }
        public string Telefono_Contacto { get; set; }
        public string usrcre { get; set; }
        public DateTime feccre { get; set; }
        public string usrmod { get; set; }
        public DateTime fecmod { get; set; }


    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Simulador2.Models
{
    public class Alumnos
    {
        [Key]
        public long Idperfil { get; set; }

        [Required(ErrorMessage = "Campo requerido")]
        [StringLength(85, MinimumLength = 3, ErrorMessage = "El Nombre debe tener 3 a 85 caracteres")]
        public String Nombres { get; set; }

        [Required(ErrorMessage = "Campo requerido")]
        [StringLength(85, MinimumLength = 3, ErrorMessage = "El ApellidoP debe tener 3 a 85 caracteres")]
        public String ApellidosP { get; set; }

        [Required(ErrorMessage = "Campo requerido")]
        [StringLength(85, MinimumLength = 3, ErrorMessage = "El ApellidoM debe tener 3 a 85 caracteres")]
        public String ApellidosM { get; set; }



        [Required(ErrorMessage = "Campo requerido")]
        [StringLength(12, MinimumLength = 3, ErrorMessage = "El Rfc debe tener 12 a 12 caracteres")]
        public String Rfc { get; set; }


        [Required(ErrorMessage = "Campo requerido")]
        [StringLength(15, MinimumLength = 10, ErrorMessage = "El Numero de Telefono debe tener 10 a 15 caracteres")]
        public String NumTelefono { get; set; }

        [Required(ErrorMessage = "Campo requerido")]
        [StringLength(85, MinimumLength = 10, ErrorMessage = "El Email debe tener 10 a 85 caracteres")]
        public String Email { get; set; }

        [Required(ErrorMessage = "Campo requerido")]
        [StringLength(110, MinimumLength = 3, ErrorMessage = "El Domicilio debe tener 3 a 110 caracteres")]
        public String Domicilio { get; set; }

        [Required(ErrorMessage = "Campo requerido")]
        [StringLength(85, MinimumLength = 3, ErrorMessage = "La Colonia debe tener 3 a 85 caracteres")]
        public String Colonia { get; set; }

        [Required(ErrorMessage = "Campo requerido")]
        [StringLength(6, MinimumLength = 3, ErrorMessage = "El Codigo Postal debe tener 3 a 6 caracteres")]
        public String CodigoPostal { get; set; }

        [Required(ErrorMessage = "Campo requerido")]
        [StringLength(85, MinimumLength = 3, ErrorMessage = "El Estado debe tener 3 a 85 caracteres")]
        public String Estado { get; set; }

        [Required(ErrorMessage = "Campo requerido")]
        [StringLength(90, MinimumLength = 3, ErrorMessage = "La Ciudad debe tener 3 a 90 caracteres")]
        public String Ciudad { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace Simulador2.Models
{
    public class EstimacionServicios
    {
        [Key]
        public long Idsuscripcion { get; set; }

      
        public String unidad_produccion { get; set; }

        
        public int TotalSuscripciones { get; set; }

        
        public String TotalMensual { get; set; }
    }
}

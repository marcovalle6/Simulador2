using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Simulador2.Models;

namespace Simulador2.Models
{
    public class Simulador2Context : DbContext
    {
        public Simulador2Context (DbContextOptions<Simulador2Context> options)
            : base(options)
        {
        }

        public DbSet<Simulador2.Models.Alumnos> Alumnos { get; set; }

        public DbSet<Simulador2.Models.EstimacionServicios> EstimacionServicios { get; set; }
    }
}

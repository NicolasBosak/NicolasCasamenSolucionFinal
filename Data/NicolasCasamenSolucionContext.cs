using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using NicolasCasamenSolucion.Models;

namespace NicolasCasamenSolucion.Data
{
    public class NicolasCasamenSolucionContext : DbContext
    {
        public NicolasCasamenSolucionContext (DbContextOptions<NicolasCasamenSolucionContext> options)
            : base(options)
        {
        }

        public DbSet<NicolasCasamenSolucion.Models.Burger> Burger { get; set; } = default!;
        public DbSet<NicolasCasamenSolucion.Models.Promo> Promo { get; set; } = default!;
    }
}

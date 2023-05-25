using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CRUDVacinas73CAllan.Models;

namespace CRUDVacinas73CAllan.Data
{
    public class CRUDVacinas73CAllanContext : DbContext
    {
        public CRUDVacinas73CAllanContext (DbContextOptions<CRUDVacinas73CAllanContext> options)
            : base(options)
        {
        }

        public DbSet<CRUDVacinas73CAllan.Models.Enfermeiro> Enfermeiro { get; set; } = default!;

        public DbSet<CRUDVacinas73CAllan.Models.Setor>? Setor { get; set; }

        public DbSet<CRUDVacinas73CAllan.Models.Vacina>? Vacina { get; set; }
    }
}

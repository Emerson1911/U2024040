using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using U20240408.EntidadesDeNegocio;

namespace U20240408.AccesoADatos
{
    
        public class AppDbContext : DbContext
        {
            public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
            public DbSet<PersonaU> PersonaU { get; set; }
        }
    
}

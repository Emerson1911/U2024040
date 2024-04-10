using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace U20240408.AccesoADatos
{
    public class AppDbContextFactory
    {
        public AppDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<AppDbContext>();
            const string conn = "Data Source=.;Initial Catalog=U20240408DB;Integrated Security=True;Encrypt=False";
            optionsBuilder.UseSqlServer(conn);
            return new AppDbContext(optionsBuilder.Options);
        }
    }
}

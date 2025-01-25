using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using APIProyectoFinal;

namespace APIProyectoFinal.Data
{
    public class APIProyectoFinalContext : DbContext
    {
        public APIProyectoFinalContext (DbContextOptions<APIProyectoFinalContext> options)
            : base(options)
        {
        }

        public DbSet<APIProyectoFinal.User> User { get; set; } = default!;
    }
}

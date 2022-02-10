using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ApiNew.Models;

namespace ApiNew.Data
{
    public class ApiNewContext : DbContext
    {
        public ApiNewContext (DbContextOptions<ApiNewContext> options)
            : base(options)
        {
        }

        public DbSet<ApiNew.Models.Pais> Pais { get; set; }

        public DbSet<ApiNew.Models.Provincia> Provincia { get; set; }

        public DbSet<ApiNew.Models.Animal> Animal { get; set; }
    }
}

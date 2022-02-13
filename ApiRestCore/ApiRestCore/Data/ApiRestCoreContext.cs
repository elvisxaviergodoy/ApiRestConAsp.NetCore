using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ApiRestCore.Models;

namespace ApiRestCore.Data
{
    public class ApiRestCoreContext : DbContext
    {
        public ApiRestCoreContext (DbContextOptions<ApiRestCoreContext> options)
            : base(options)
        {
        }

        public DbSet<ApiRestCore.Models.Producto> Producto { get; set; }
    }
}

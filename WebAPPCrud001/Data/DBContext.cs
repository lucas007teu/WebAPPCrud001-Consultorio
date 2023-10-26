using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebAPPCrud001.Models;

namespace WebAPPCrud001.Data
{
    public class DBContext : DbContext
    {
        public DBContext (DbContextOptions<DBContext> options)
            : base(options)
        {
        }

        public DbSet<WebAPPCrud001.Models.Consultas> Consultas { get; set; } = default!;
    }
}

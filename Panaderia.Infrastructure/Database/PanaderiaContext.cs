using Microsoft.EntityFrameworkCore;
using Panaderia.ApplicationCore.Models;

namespace Panaderia.Infrastructure.Database
{
    public class PanaderiaContext : DbContext
    {
        public PanaderiaContext(DbContextOptions<PanaderiaContext> options) : base(options)
        {
        }

        public DbSet<Proveedor> Proveedor { get; set; }
        public DbSet<Pan> Pan { get; set; }
    }
}
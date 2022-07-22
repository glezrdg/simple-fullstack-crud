using FBTarjeta.Models;
using Microsoft.EntityFrameworkCore;

namespace FBTarjeta
{
    public class ApplicationDbContext: DbContext
    {
        public DbSet<TarjetaCredito> TarjetaCredito { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options): base(options)
        {

        }
    }
}

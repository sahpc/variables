using Microsoft.EntityFrameworkCore;
using variables.Models;

namespace variables.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        // Definir DbSet para la entidad ClientesModel
        public DbSet<ClientesModel> Clientes { get; set; }
    }
}

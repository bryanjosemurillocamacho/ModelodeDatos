using Microsoft.EntityFrameworkCore;

namespace tareaTallerCRUDMurilloCamacho.Models
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Cliente> Clientes { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // Configura la cadena de conexión a tu base de datos
            optionsBuilder.UseSqlServer("Server=localhost\\SQLEXPRESS;Database=TallerCRUD;Trusted_Connection=True;");
        }
    }
}

using Microsoft.EntityFrameworkCore;
using SGP_Certificado.Models;

namespace SGP_Certificado.Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<TurmaModel> Cadastro_Turmas { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlServer("Server=(localdb)\\MSSQLLocaldb;Database=Cadastro_Turmas;MultipleActiveResultSets=true;Encrypt=YES;TrustServerCertificate=YES");
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

    }



}

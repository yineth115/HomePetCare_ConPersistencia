using Microsoft.EntityFrameworkCore;
using HomePetCare.App.Dominio;

namespace HomePetCare.App.Persistencia
{
    public class AppContext : DbContext
    {
        public DbSet<Individuo> Individuos { get; set; }
        //public DbSet<Mascota> Mascota { get; set; }
        //public DbSet<Veterinario> Veterinario { get; set; }
        //public DbSet<Enfermera> Enfermeras { get; set; }
        //public DbSet<Propietario> Propietario { get; set; }
        public DbSet<SignoVital> SignosVitales { get; set; }
        public DbSet<Historia> Historias { get; set; }
        public DbSet<Recomendaciones> Recomendaciones { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder
               .UseSqlServer("Data Source = QA-YINETHT1\\SQLSERVER2019;User ID=sa;Password=Sql2022*;Initial Catalog=HomePetCareData");
               //.UseSqlServer("Server=tcp:misiontic2022.database.windows.net,1433;Initial Catalog=HomePetCare;Persist Security Info=False;User ID=admin_01;Password=09122006_Hf;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
            
            }
        }

    }
}
using Microsoft.EntityFrameworkCore;
using wpEntity;

namespace wpContextEntrega
{
    public class WebPixEntregaContext : DbContext
    {
       


        public DbSet<Transportadora> Transportadora { get; set; }
        public DbSet<CEP> CEP { get; set; }
        public DbSet<Propiedade> Propiedade { get; set; }
        public DbSet<Valor> Valor { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // optionsBuilder.UseSqlServer(@"Server=DESKTOP-9B04LJT\SQLEXPRESS;Database=WebPixPrincipal;Trusted_Connection=True;Integrated Security = True;");
            optionsBuilder.UseSqlServer(@"Server = 187.84.229.35; Database = WebPixEntrega; User Id = dev;Password = Lucas-2007");
        }

    }
}

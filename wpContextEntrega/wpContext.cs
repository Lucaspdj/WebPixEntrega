using Microsoft.EntityFrameworkCore;
using wpEntity;

namespace wpContextEntrega
{
    public class WebPixContext : DbContext
    {
        public WebPixContext() : base()
        {
        }

        public DbSet<Transportadora> Produto { get; set; }
        public DbSet<CEP> ProdutoSku { get; set; }
        public DbSet<Propiedade> Propiedades { get; set; }
        public DbSet<Valor> Preco { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // optionsBuilder.UseSqlServer(@"Server=DESKTOP-9B04LJT\SQLEXPRESS;Database=WebPixPrincipal;Trusted_Connection=True;Integrated Security = True;");
            optionsBuilder.UseSqlServer(@"Server = 187.84.229.35; Database = WebPixEntrega; User Id = dev;Password = Lucas-2007");
        }

    }
}

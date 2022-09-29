using Hotel.Comum.Modelos;
using System.Data.Entity;

namespace Hotel.Repositorio.EF
{
    public class HotelDbContext: DbContext
    {
        public HotelDbContext() : base(@"Server=2K21-DELL\SQLEXPRESS;Database=HotelEngegraph_EF;User=sa;Password=123456")
        {
            DbConfiguration.SetConfiguration(new ConfiguracaoDatabase());
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<HotelDbContext, MigrationsConfiguration>());
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //adicionar convenções e foreign keys
        }

        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<TipoUh> TiposUh { get; set; }
        public DbSet<Uh> Uhs { get; set; }
        public DbSet<Reserva> Reservas { get; set; }
        public DbSet<Ocupacao> Ocupacoes { get; set; }
        public DbSet<Configuracao> Configuracoes { get; set; }
        public DbSet<Hospede> Hospedes { get; set; }
        public DbSet<HospedeOcupacao> HospedesOcupacao { get; set; }
        public DbSet<Lancamentos> Lancamentos { get; set; }
        public DbSet<TipoPagto> TiposPgto { get; set; }
        public DbSet<CheckOut> CheckOuts { get; set; }

    }
}

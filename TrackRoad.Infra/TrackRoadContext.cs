using Microsoft.EntityFrameworkCore;
using TrackRoad.Infra.Domain;

namespace TrackRoad.Infra
{
    public class TrackRoadContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlServer(@"server =.\SQLEXPRESS; database=TrackRoad.Db;trusted_connection=true;");

        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Combustivel> Combustiveis { get; set; }
        public DbSet<Contrato> Contratos { get; set; }
        public DbSet<Motorista> Motoristas { get; set; }
        public DbSet<Viagem> Viagens { get; set; }
    }


}

using Microsoft.EntityFrameworkCore;
using TrackRoad.Infra.Domain;

namespace TrackRoad.Infra.Persistence
{
    public class TrackRoadContext : DbContext
    {
        public TrackRoadContext(DbContextOptions<TrackRoadContext> options) : base(options) { }

        public DbSet<Cliente> Clientes { get; set; }


        //public DbSet<Usuario> Usuarios { get; set; }
        //public DbSet<Combustivel> Combustiveis { get; set; }
        //public DbSet<Contrato> Contratos { get; set; }
        //public DbSet<Motorista> Motoristas { get; set; }
        //public DbSet<Viagem> Viagens { get; set; }
    }
}
using Entidades;
using System.Data.Entity;

namespace DAL
{
    public class TrackRoadContext : DbContext
    {
        public TrackRoadContext() : base("TrackRoad")
        {

        }

        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Combustivel> Combustiveis { get; set; }
        public DbSet<Contrato> Contratos { get; set; }
        public DbSet<Motorista> Motoristas { get; set; }
        public DbSet<Viagem> Viagens { get; set; }
    }
}

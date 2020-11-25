using DAL;
using Entidades;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TrackRoad.Application.Interfaces;
using TrackRoad.Application.ViewModels;

namespace TrackRoad.Application.Services
{
    public class ViagemAppService : IViagemAppService
    {
        public async Task<ViagemViewModel> Get(int idViagem)
        {
            var context = new TrackRoadContext();
            var viagem = context.Viagens.First(v => v.Id == idViagem);

            return new ViagemViewModel(viagem);
        }

        public async Task<IEnumerable<ViagemViewModel>> GetAll()
        {
            var context = new TrackRoadContext();
            var lista = new List<ViagemViewModel>();

            foreach (Viagem v in context.Viagens)
            {
                lista.Add(new ViagemViewModel(v));
            }

            return lista;
        }

        public async Task<IEnumerable<ViagemViewModel>> Search(string pesquisa)
        {
            var context = new TrackRoadContext();
            var viagens = context.Viagens.Where(v => v.CidadeDestino.Contains(pesquisa));

            var lista = new List<ViagemViewModel>();

            foreach (Viagem v in viagens)
            {
                lista.Add(new ViagemViewModel(v));
            }

            return lista;
        }

        public async Task<ViagemViewModel> Add(Viagem viagem)
        {
            var db = new TrackRoadContext();
            db.Viagens.Add(viagem);
            db.SaveChanges();

            return new ViagemViewModel(viagem);
        }

        public async Task Delete(int id)
        {
            var context = new TrackRoadContext();
            var viagem = context.Viagens.First(v => v.Id == id);

            context.Viagens.Remove(viagem);
            context.SaveChanges();
        }

        public async Task Update(Viagem viagem)
        {
            var context = new TrackRoadContext();
            var response = context.Viagens.First(v => v.Id == viagem.Id);

            response.Id = viagem.Id;
            response.TotalDistancia = viagem.TotalDistancia;
            response.EnderecoDestino = viagem.EnderecoDestino;
            response.NumeroDestino = viagem.NumeroDestino;
            response.BairroDestino = viagem.BairroDestino;
            response.CidadeDestino = viagem.CidadeDestino;
            response.EstadoDestino = viagem.EstadoDestino;
            response.CepDestino = viagem.CepDestino;
            response.IdMotorista = viagem.IdMotorista;

            context.SaveChanges();
        }
    }
}

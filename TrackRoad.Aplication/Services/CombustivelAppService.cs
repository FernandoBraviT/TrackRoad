using DAL;
using Entidades;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TrackRoad.Application.Interfaces;
using TrackRoad.Application.ViewModels;

namespace TrackRoad.Application.Services
{
    public class CombustivelAppService : ICombustivelAppService
    {
        public async Task<CombustivelViewModel> Get(int id)
        {
            var context = new TrackRoadContext();
            var combustivel = context.Combustiveis.First(c => c.Id == id);

            return new CombustivelViewModel(combustivel);
        }

        public async Task<IEnumerable<CombustivelViewModel>> GetAll()
        {
            var context = new TrackRoadContext();
            var lista = new List<CombustivelViewModel>();

            foreach (Combustivel c in context.Combustiveis)
            {
                lista.Add(new CombustivelViewModel(c));
            }

            return lista;
        }

        public async Task<IEnumerable<CombustivelViewModel>> Search(string pesquisa)
        {
            var context = new TrackRoadContext();
            var combustiveis = context.Combustiveis.Where(c => c.Nome.Contains(pesquisa));

            var lista = new List<CombustivelViewModel>();

            foreach (Combustivel c in combustiveis)
            {
                lista.Add(new CombustivelViewModel(c));
            }

            return lista;
        }

        public async Task<CombustivelViewModel> Add(Combustivel combustivel)
        {
            var db = new TrackRoadContext();
            db.Combustiveis.Add(combustivel);
            db.SaveChanges();

            return new CombustivelViewModel(combustivel);
        }

        public async Task Delete(int id)
        {
            var context = new TrackRoadContext();
            var combustivel = context.Combustiveis.First(c => c.Id == id);

            context.Combustiveis.Remove(combustivel);
            context.SaveChanges();
        }

        public async Task Update(Combustivel combustivel)
        {
            var context = new TrackRoadContext();
            var response = context.Combustiveis.First(u => u.Id == combustivel.Id);

            response.Id = combustivel.Id;
            response.Nome = combustivel.Nome;
            response.Preco = combustivel.Preco;

            context.SaveChanges();
        }

    }
}

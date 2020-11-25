using DAL;
using Entidades;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TrackRoad.Application.Interfaces;
using TrackRoad.Application.ViewModels;

namespace TrackRoad.Application.Services
{
    public class ContratoAppService : IContratoAppService
    {
        public async Task<ContratoViewModel> Get(int idContrato)
        {
            var context = new TrackRoadContext();
            var contrato = context.Contratos.First(u => u.Id == idContrato);

            return new ContratoViewModel(contrato);
        }

        public async Task<IEnumerable<ContratoViewModel>> GetAll()
        {
            var context = new TrackRoadContext();
            var lista = new List<ContratoViewModel>();


            foreach (Contrato c in context.Contratos)
            {
                lista.Add(new ContratoViewModel(c));
            }

            return lista;
        }

        public async Task<IEnumerable<ContratoViewModel>> Search(string pesquisa)
        {
            var context = new TrackRoadContext();
            var contratos = context.Contratos.Where(u => u.Empresa.Contains(pesquisa));

            var lista = new List<ContratoViewModel>();

            foreach (Contrato c in contratos)
            {
                lista.Add(new ContratoViewModel(c));
            }

            return lista;
        }

        public async Task<ContratoViewModel> Add(Contrato contrato)
        {
            var db = new TrackRoadContext();
            db.Contratos.Add(contrato);
            db.SaveChanges();

            return new ContratoViewModel(contrato);
        }

        public async Task Delete(int id)
        {
            var context = new TrackRoadContext();
            var contrato = context.Contratos.First(u => u.Id == id);

            context.Contratos.Remove(contrato);
            context.SaveChanges();
        }

        public async Task Update(Contrato contrato)
        {
            var context = new TrackRoadContext();
            var response = context.Contratos.First(c => c.Id == contrato.Id);

            response.Id = contrato.Id;
            response.Empresa = contrato.Empresa;
            response.Valor = contrato.Valor;
            response.Doc = contrato.Doc;
            response.IdCliente = contrato.IdCliente;

            context.SaveChanges();
        }
    }
}

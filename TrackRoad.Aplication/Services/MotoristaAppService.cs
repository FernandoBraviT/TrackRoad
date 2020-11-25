using DAL;
using Entidades;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TrackRoad.Application.Interfaces;
using TrackRoad.Application.ViewModels;

namespace TrackRoad.Application.Services
{
    public class MotoristaAppService : IMotoristaAppService
    {
        public async Task<MotoristaViewModel> Get(int idMotorista)
        {
            var context = new TrackRoadContext();
            var motorista = context.Motoristas.First(u => u.Id == idMotorista);

            return new MotoristaViewModel(motorista);
        }

        public async Task<IEnumerable<MotoristaViewModel>> GetAll()
        {
            var context = new TrackRoadContext();
            var lista = new List<MotoristaViewModel>();

            foreach (Motorista m in context.Motoristas)
            {
                lista.Add(new MotoristaViewModel(m));
            }

            return lista;
        }

        public async Task<IEnumerable<MotoristaViewModel>> Search(string pesquisa)
        {
            var context = new TrackRoadContext();
            var motoristas = context.Motoristas.Where(m => m.Nome.Contains(pesquisa));

            var lista = new List<MotoristaViewModel>();

            foreach (Motorista m in motoristas)
            {
                lista.Add(new MotoristaViewModel(m));
            }

            return lista;
        }

        public async Task<MotoristaViewModel> Add(Motorista motorista)
        {
            var db = new TrackRoadContext();
            db.Motoristas.Add(motorista);
            db.SaveChanges();

            return new MotoristaViewModel(motorista);
        }

        public async Task Delete(int id)
        {
            var context = new TrackRoadContext();
            var motorista = context.Motoristas.First(m => m.Id == id);

            context.Motoristas.Remove(motorista);
            context.SaveChanges();
        }

        public async Task Update(Motorista motorista)
        {
            var context = new TrackRoadContext();
            var response = context.Motoristas.First(m => m.Id == motorista.Id);

            response.Id = motorista.Id;
            response.Nome = motorista.Nome;
            response.Cnh = motorista.Cnh;
            response.TipoVeiculo = motorista.TipoVeiculo;
            response.ModeloVeiculo = motorista.ModeloVeiculo;
            response.MarcaVeiculo = motorista.MarcaVeiculo;
            response.AnoFabricacao = motorista.AnoFabricacao;
            response.KmLitro = motorista.KmLitro;
            response.IdCombustivel = motorista.IdCombustivel;
            response.Combustivel = motorista.Combustivel;

            context.SaveChanges();
        }

    }
}
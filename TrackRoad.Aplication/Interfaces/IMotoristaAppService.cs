using Entidades;
using System.Collections.Generic;
using System.Threading.Tasks;
using TrackRoad.Application.ViewModels;

namespace TrackRoad.Application.Interfaces
{
    public interface IMotoristaAppService
    {
        Task<MotoristaViewModel> Get(int id);
        Task<IEnumerable<MotoristaViewModel>> GetAll();
        Task<IEnumerable<MotoristaViewModel>> Search(string pesquisa);
        Task<MotoristaViewModel> Add(Motorista motorista);
        Task Delete(int id);
        Task Update(Motorista motorista);
    }
}

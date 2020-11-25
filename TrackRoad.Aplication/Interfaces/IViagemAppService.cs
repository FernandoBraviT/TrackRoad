using Entidades;
using System.Collections.Generic;
using System.Threading.Tasks;
using TrackRoad.Application.ViewModels;

namespace TrackRoad.Application.Interfaces
{
    public interface IViagemAppService
    {
        Task<ViagemViewModel> Get(int id);
        Task<IEnumerable<ViagemViewModel>> GetAll();
        Task<IEnumerable<ViagemViewModel>> Search(string pesquisa);
        Task<ViagemViewModel> Add(Viagem viagem);
        Task Delete(int id);
        Task Update(Viagem viagem);
    }
}

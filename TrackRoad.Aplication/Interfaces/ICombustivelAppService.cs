using Entidades;
using System.Collections.Generic;
using System.Threading.Tasks;
using TrackRoad.Application.ViewModels;

namespace TrackRoad.Application.Interfaces
{
    public interface ICombustivelAppService
    {
        Task<CombustivelViewModel> Get(int id);
        Task<IEnumerable<CombustivelViewModel>> GetAll();
        Task<IEnumerable<CombustivelViewModel>> Search(string pesquisa);
        Task<CombustivelViewModel> Add(Combustivel combustivel);
        Task Delete(int id);
        Task Update(Combustivel id);
    }
}

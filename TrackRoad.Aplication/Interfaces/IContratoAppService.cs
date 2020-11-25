using Entidades;
using System.Collections.Generic;
using System.Threading.Tasks;
using TrackRoad.Application.ViewModels;

namespace TrackRoad.Application.Interfaces
{
    public interface IContratoAppService
    {
        Task<ContratoViewModel> Get(int id);
        Task<IEnumerable<ContratoViewModel>> GetAll();
        Task<IEnumerable<ContratoViewModel>> Search(string pesquisa);
        Task<ContratoViewModel> Add(Contrato contrato);
        Task Delete(int id);
        Task Update(Contrato contrato);
    }
}

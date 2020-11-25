using Entidades;
using System.Collections.Generic;
using System.Threading.Tasks;
using TrackRoad.Application.ViewModels;

namespace TrackRoad.Application.Interfaces
{
    public interface IUsuarioAppService
    {
        Task<UsuarioViewModel> Get(int id);
        Task<IEnumerable<UsuarioViewModel>> GetAll();
        Task<IEnumerable<UsuarioViewModel>> Search(string pesquisa);
        Task<UsuarioViewModel> Add(Usuario usuario);
        Task Delete(int id);
        Task Update(Usuario usuario);
    }
}

using Entidades;
using Entidades.ViewModels;
using System.Collections.Generic;

namespace TrackRoad.Application.Interfaces
{
    public interface IClienteAppService
    {
        ClienteViewModel Get(int id);
        IEnumerable<ClienteViewModel> GetAll();
        IEnumerable<ClienteViewModel> Search(string pesquisa);
        ClienteViewModel Add(ClienteViewModel cliente);
        void Delete(int id);
        void Update(ClienteViewModel cliente);
    }
}
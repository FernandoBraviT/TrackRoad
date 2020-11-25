using AutoFixture;
using DAL;
using Entidades;
using Entidades.ViewModels;
using System.Collections.Generic;
using System.Linq;

namespace TrackRoad.App.Services
{
    public class ClienteAppService
    {
        private readonly TrackRoadContext _context;
        private readonly Fixture _fixture;

        public ClienteAppService()
        {
            _context = new TrackRoadContext();
            _fixture = new Fixture();
        }

        #region Mock

        //public ClienteViewModel Get(int id)
        //{
        //    return _fixture.Create<ClienteViewModel>();
        //}

        //public IEnumerable<ClienteViewModel> GetAll()
        //{
        //    return _fixture.CreateMany<ClienteViewModel>(7);
        //}

        //public ClienteViewModel Add(ClienteViewModel clienteViewModel)
        //{
        //    clienteViewModel.Id = 10;
        //    return clienteViewModel;
        //}

        //public ClienteViewModel Update(ClienteViewModel clienteView)
        //{


        //    return clienteView;
        //}

        //public void Delete(int id)
        //{

        //}

        #endregion

        #region Entity Framework

        public ClienteViewModel Get(int id)
        {
            var cliente = _context.Clientes.First(c => c.Id == id);

            return new ClienteViewModel(cliente);
        }

        public IEnumerable<ClienteViewModel> GetAll()
        {
            var lista = new List<ClienteViewModel>();

            foreach (Cliente c in _context.Clientes)
            {
                lista.Add(new ClienteViewModel(c));
            }

            return lista;
        }

        public IEnumerable<ClienteViewModel> Search(string pesquisa)
        {
            var context = new TrackRoadContext();
            var clientes = _context.Clientes.Where(c => c.NomeFantasia.Contains(pesquisa));

            var lista = new List<ClienteViewModel>();

            foreach (Cliente c in clientes)
            {
                lista.Add(new ClienteViewModel(c));
            }

            return lista;
        }

        public ClienteViewModel Add(ClienteViewModel clienteViewModel)
        {
            var cliente = new Cliente(clienteViewModel);
            _context.Clientes.Add(cliente);
            _context.SaveChanges();

            return new ClienteViewModel(cliente);
        }

        public void Delete(int id)
        {
            var cliente = _context.Clientes.First(c => c.Id == id);

            _context.Clientes.Remove(cliente);
            _context.SaveChanges();
        }

        public ClienteViewModel Update(ClienteViewModel clienteViewModel)
        {
            var cliente = new Cliente(clienteViewModel);

            // todo: update clientes

            var clienteRetorno = new ClienteViewModel(cliente);
            return clienteRetorno;
        }

        #endregion
    }
}
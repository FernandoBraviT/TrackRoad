using DAL;
using Entidades;
using Entidades.ViewModels;
using System.Collections.Generic;
using System.Linq;
using TrackRoad.Application.Interfaces;

namespace TrackRoad.Application.Services
{
    public class ClienteAppService : IClienteAppService
    {
        private readonly TrackRoadContext _context;


        public ClienteAppService()
        {
            _context = new TrackRoadContext();
        }

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

        public void Update(ClienteViewModel cliente)
        {
            var context = new TrackRoadContext();
            var response = context.Clientes.First(c => c.Id == cliente.Id);

            response.Id = cliente.Id;
            response.NomeFantasia = cliente.NomeFantasia;
            response.RazaoSocial = cliente.RazaoSocial;
            response.Cnpj = cliente.Cnpj;
            response.RamoAtividade = cliente.RamoAtividade;
            response.Endereco = cliente.Endereco;
            response.Numero = cliente.Numero;
            response.Bairro = cliente.Bairro;
            response.Cidade = cliente.Cidade;
            response.Estado = cliente.Estado;
            response.Cep = cliente.Cep;

            context.SaveChanges();
        }

    }
}
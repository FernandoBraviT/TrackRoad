using DAL;
using Entidades;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TrackRoad.Application.Interfaces;
using TrackRoad.Application.ViewModels;

namespace TrackRoad.Application.Services
{
    public class UsuarioAppService : IUsuarioAppService
    {
        public async Task<UsuarioViewModel> Get(int idUsuario)
        {
            var context = new TrackRoadContext();
            var usuario = context.Usuarios.First(u => u.Id == idUsuario);

            return new UsuarioViewModel(usuario);
        }

        public async Task<IEnumerable<UsuarioViewModel>> GetAll()
        {
            var context = new TrackRoadContext();
            var lista = new List<UsuarioViewModel>();

            foreach (Usuario u in context.Usuarios)
            {
                lista.Add(new UsuarioViewModel(u));
            }

            return lista;
        }

        public async Task<IEnumerable<UsuarioViewModel>> Search(string pesquisa)
        {
            var context = new TrackRoadContext();
            var usuarios = context.Usuarios.Where(u => u.Login.Contains(pesquisa));

            var lista = new List<UsuarioViewModel>();

            foreach (Usuario u in usuarios)
            {
                lista.Add(new UsuarioViewModel(u));
            }

            return lista;
        }

        public async Task<UsuarioViewModel> Add(Usuario usuario)
        {
            var db = new TrackRoadContext();
            db.Usuarios.Add(usuario);
            db.SaveChanges();

            return new UsuarioViewModel(usuario);
        }

        public async Task Delete(int id)
        {
            var context = new TrackRoadContext();
            var usuario = context.Usuarios.First(u => u.Id == id);

            context.Usuarios.Remove(usuario);
            context.SaveChanges();
        }

        public async Task Update(Usuario usuario)
        {
            var context = new TrackRoadContext();
            var response = context.Usuarios.First(u => u.Id == usuario.Id);

            response.Id = usuario.Id;
            response.Login = usuario.Login;
            response.Password = usuario.Password;
            response.Email = usuario.Email;
            response.Tipo = usuario.Tipo;

            context.SaveChanges();
        }
    }
}

using Entidades.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using TrackRoad.Application.Interfaces;
using TrackRoad.Application.Services;
using TrackRoad.Application.ViewModels;

namespace TrackRoad.MVC.Controllers
{
    public class ClienteController : Controller
    {
        private readonly ClienteAppService _clienteApp;

        public ClienteController()
        {
            _clienteApp = new ClienteAppService();
        }

        public async Task<ActionResult> Index()
        {
            var listaUsuarios = _clienteApp.GetAll();

            return View(listaUsuarios);
        }

        public async Task<ActionResult> Details(int id)
        {
            return View(_clienteApp.Get(id));
        }

        public async Task<ActionResult> Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create(ClienteViewModel viewModel)
        {
            try
            {
                if (!ModelState.IsValid) return View(viewModel);

                var resultado = _clienteApp.Add(viewModel);

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        public async Task<ActionResult> Edit(int id)
        {
            return View(_clienteApp.Get(id));
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit(int id, ClienteViewModel collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        public async Task<ActionResult> Delete(int id)
        {
            return View(_clienteApp.Get(id));
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Delete(int id, ClienteViewModel collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}

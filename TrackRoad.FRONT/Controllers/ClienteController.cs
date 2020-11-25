using Entidades.ViewModels;
using System.Web.Mvc;
using TrackRoad.App.Services;

namespace TrackRoad.FRONT.Controllers
{
    public class ClienteController : Controller
    {
        private readonly ClienteAppService _clienteApp;

        public ClienteController()
        {
            _clienteApp = new ClienteAppService();
        }

        public ActionResult Index()
        {
            var clientes = _clienteApp.GetAll();
            return View(clientes);
        }

        public ActionResult Details(int id)
        {
            var cliente = _clienteApp.Get(id);
            return View(cliente);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(ClienteViewModel viewModel)
        {
            try
            {
                if (!ModelState.IsValid) return View(viewModel);

                _clienteApp.Add(viewModel);

                return RedirectToAction("Index", "Home");
            }
            catch
            {
                return View(viewModel);
            }
        }

        public ActionResult Edit(int id)
        {
            var cliente = _clienteApp.Get(id);
            return View(cliente);
        }

        [HttpPost]
        public ActionResult Edit(int id, ClienteViewModel viewModel)
        {
            try
            {
                if (!ModelState.IsValid) return View(viewModel);
                _clienteApp.Update(viewModel);
                return RedirectToAction("Index");
            }
            catch
            {
                return View(viewModel);
            }
        }

        public ActionResult Delete(int id)
        {
            var cliente = _clienteApp.Get(id);
            return View(cliente);
        }

        [HttpPost]
        public ActionResult Delete(int id, ClienteViewModel viewModel)
        {
            try
            {
                _clienteApp.Delete(id);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}

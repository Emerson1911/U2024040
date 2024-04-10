using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using U20240408.EntidadesDeNegocio;
using U20240408.LogicaDeNegocio;

namespace U20240408.UI.AppWebMVC.Controllers
{
    public class PersonaController : Controller
    {
        readonly PersonaMBL _personaMBL;
        public PersonaController(PersonaMBL personaMBL)
        {
            _personaMBL = personaMBL;
        }
        // GET: PersonaController
        public async Task<ActionResult> Index(PersonaU personaM)
        {
            var persona = await _personaMBL.Buscar(personaM);
            return View(persona);
        }

        // GET: PersonaController/Details/5
        public async Task<ActionResult> Details(int id)
        {
            var clientes = await _personaMBL.ObtenerPoId(new PersonaU { Id = id });
            return View(clientes);
        }

        // GET: PersonaController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: PersonaController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create(PersonaU personaM)
        {
            try
            {
                await _personaMBL.Crear(personaM);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: PersonaController/Edit/5
        public async Task<ActionResult> Edit(int id)
        {
            var persona = await _personaMBL.ObtenerPoId(new PersonaU { Id = id });
            return View(persona);
        }

        // POST: PersonaController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit(PersonaU personaM)
        {
            try
            {
                await _personaMBL.Modificar(personaM);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: PersonaController/Delete/5
        public async Task<ActionResult> Delete(int id)
        {
            var clientes = await _personaMBL.ObtenerPoId(new PersonaU { Id = id });
            return View(clientes);
        }

        // POST: PersonaController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Delete(int id, PersonaU personaM)
        {
            try
            {
                await _personaMBL.Eliminar(personaM);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}

using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using U20240408.EntidadesDeNegocio;
using U20240408.LogicaDeNegocio;

namespace U20240408.UI.AppWebMVC.Controllers
{
    public class PersonaController : Controller
    {
        readonly PersonaUBL _personaUBL;
        public PersonaController(PersonaUBL personaUBL)
        {
            _personaUBL = personaUBL;
        }
        // GET: PersonaController
        public async Task<ActionResult> Index(PersonaU personaU)
        {
            var persona = await _personaUBL.Buscar(personaU);
            return View(persona);
        }

        // GET: PersonaController/Details/5
        public async Task<ActionResult> Details(int id)
        {
            var clientes = await _personaUBL.ObtenerPoId(new PersonaU { Id = id });
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
        public async Task<ActionResult> Create(PersonaU personaU)
        {
            try
            {
                await _personaUBL.Crear(personaU);
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
            var persona = await _personaUBL.ObtenerPoId(new PersonaU { Id = id });
            return View(persona);
        }

        // POST: PersonaController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit(PersonaU personaU)
        {
            try
            {
                await _personaUBL.Modificar(personaU);
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
            var clientes = await _personaUBL.ObtenerPoId(new PersonaU { Id = id });
            return View(clientes);
        }

        // POST: PersonaController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Delete(int id, PersonaU personaU)
        {
            try
            {
                await _personaUBL.Eliminar(personaU);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}

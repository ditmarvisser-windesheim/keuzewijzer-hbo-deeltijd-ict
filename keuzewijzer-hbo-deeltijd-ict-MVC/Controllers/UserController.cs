using keuzewijzer_hbo_deeltijd_ict_MVC.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using keuzewijzer_hbo_deeltijd_ict_MVC.Models;
using keuzewijzer_hbo_deeltijd_ict_MVC.Services;

namespace keuzewijzer_hbo_deeltijd_ict_MVC.Controllers
{
    public class UserController : Controller
    {

        private readonly IService<User> _service;

        public UserController(IService<User> service)
        {
            _service = service;
        }

        // GET: UserController
        public async Task<ActionResult> Index()
        {
            return View(await _service.GetAsync("/api/User"));
        }

        // GET: UserController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: UserController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: UserController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create(User user)
        {
            if (await _service.AddAsync(user, "/api/User"))
            {
                return RedirectToAction(nameof(Index));
            }

            return View();
        }

        // GET: UserController/Edit/5
        public async Task<ActionResult> Edit(int id)
        {
            return View(await _service.GetAsync(id, "/api/User"));
        }

        // POST: UserController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit(int id, User user)
        {
            if (await _service.UpdateAsync(id, user, "/api/User"))
            {
                return RedirectToAction(nameof(Index));
            }

            return View(await _service.GetAsync(id, "/api/User"));
        }

        // GET: UserController/Delete/5
        public async Task<ActionResult> Delete(int id)
        {
            var user = await _service.GetAsync(id, "/api/User");
            if (user == null) return NotFound();
            return View(user);
        }

        // POST: UserController/Delete/5
        // POST: Teacher/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id, IFormCollection collection)
        {
            if (await _service.DeleteAsync(id, "/api/User")) return RedirectToAction(nameof(Index));
            return View();
        }
    }
}

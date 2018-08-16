using Microsoft.AspNet.Identity;
using SowAndReap.Models.Plant;
using SowAndReap.Services;
using System;
using System.Web.Mvc;

namespace SowAndReap.WebMVC.Controllers
{
    [Authorize]
    public class PlantController : Controller
    {
        // GET: Plant
        public ActionResult Index()
        {
            var userId = Guid.Parse(User.Identity.GetUserId());
            var service = new PlantService(userId);
            var model = service.GetPlants();

            //var model = new SinglePlantView[0];

            return View(model);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]

        public ActionResult Create(PlantCreate model)
        {
            if (!ModelState.IsValid) return View(model);

            var userId = Guid.Parse(User.Identity.GetUserId());
            var service = new PlantService(userId);

            service.CreatePlant(model);

            return RedirectToAction("Index");
        }
    }
}
using SowAndReap.Models;
using SowAndReap.WebMVC.Models.Plant;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SowAndReap.WebMVC.Controllers
{
    [Authorize]
    public class PlantController : Controller
    {
        // GET: Plant
        public ActionResult Index()
        {
            var model = new SinglePlantView[0];
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
            if (ModelState.IsValid) { }

            return View(model);
        }
    }
}
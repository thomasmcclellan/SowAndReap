using SowAndReap.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SowAndReap.WebMVC.Controllers
{
    [Authorize]
    public class MaterialController : Controller
    {
        // GET: Material
        public ActionResult Index()
        {
            var model = new SingleMaterialItem[0];
            return View();
        }
    }
}
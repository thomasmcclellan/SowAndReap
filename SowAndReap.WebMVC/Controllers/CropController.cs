using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SowAndReap.WebMVC.Controllers
{
    public class CropController : Controller
    {
        // GET: Crop
        public ActionResult Index()
        {
            return View();
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace JS.Test.Controllers
{
    public class DropzoneController : Controller
    {
        // GET: Dropzone
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(HttpPostedFileBase file)
        {
            return View();
        }
    }
}
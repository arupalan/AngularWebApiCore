using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.IO;

namespace AngularWebApiCore.Controllers
{
    public class PartialsController : Controller
    {
        public ActionResult Index(string partial)
        {
            ViewBag.OS = Path.DirectorySeparatorChar.ToString() == @"/" ? "Non Windows" : "Windows";
            //ViewBag.Platform = System.Environment.OSVersion.ToString();
            return PartialView(partial);
        }
    }
}

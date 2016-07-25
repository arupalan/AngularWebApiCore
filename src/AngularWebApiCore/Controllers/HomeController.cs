using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.IO;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace AngularWebApiCore.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            //return Redirect("index.chtml");
            //var os = Environment.OSVersion;
            //ViewBag.OS = string.Format("Platform: {0:G} {1}.{2}",os.Platform,os.Version.Major,os.Version.Minor);
            ViewBag.OS = Path.DirectorySeparatorChar.ToString() == @"/" ? "Non WIndows" : "Windows";
            return View();
        }

        public IActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewBag.Message = "Your contact page...";

            return View("~/views/home/contact.cshtml");
        }

        public string ThrowError()
        {
            string name = null;
            return name.ToLower();
        }

        public IActionResult Error()
        {
            return View("~/Views/Shared/Error.cshtml");
        }

    }
}

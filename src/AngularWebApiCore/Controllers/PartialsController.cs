﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace AngularWebApiCore.Controllers
{
    public class PartialsController : Controller
    {
        public ActionResult Index(string partial)
        {
            return PartialView(partial);
        }
    }
}

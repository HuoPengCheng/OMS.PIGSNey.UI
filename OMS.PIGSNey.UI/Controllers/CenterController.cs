﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace OMS.PIGSNey.UI.Controllers
{
    public class CenterController : Controller
    {
        public IActionResult KeHu()
        {
            return View();
        }
        public IActionResult WeiXui()
        {
            return View();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace OMS.PIGSNey.UI.Controllers
{
    public class XYController : Controller
    {
        public IActionResult MaterialShow()
        {
            return View();
        }

        public IActionResult ToolShow()
        {
            return View();
        }

       
        public IActionResult MaterialShenHe()
        {
            
            return View();
        }

        public IActionResult ToolShenHe()
        {

            return View();
        }
        

    }
}
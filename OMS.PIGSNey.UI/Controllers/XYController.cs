using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace OMS.PIGSNey.UI.Controllers
{
    public class XYController : Controller
    {
        private IConfiguration _configuration;

        public XYController(IConfiguration configuration)
        {
            this._configuration = configuration;
        }
        public IActionResult MaterialShow()
        {
            string url = _configuration["apiUrl"];
            ViewBag.url = url;
            return View();
        }

        public IActionResult ToolShow()
        {
            string url = _configuration["apiUrl"];
            ViewBag.url = url;
            return View();
        }

       
        public IActionResult MaterialShenHe()
        {
            string url = _configuration["apiUrl"];
            ViewBag.url = url;

            return View();
        }

        public IActionResult ToolShenHe()
        {
            string url = _configuration["apiUrl"];
            ViewBag.url = url;

            return View();
        }
        

    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace OMS.PIGSNey.UI.Controllers
{
    public class JurisdictionController : Controller
    {
        private IConfiguration _configuration;

        public JurisdictionController(IConfiguration configuration)
        {
            this._configuration = configuration;
        }
        public IActionResult Index()
        {
            string url = _configuration["apiUrl"];
            ViewBag.url = url;
            return View();
        }
        public IActionResult Show()
        {
            string url = _configuration["apiUrl"];
            ViewBag.url = url;
            return View();
        }
        public IActionResult Qx()
        {
            string url = _configuration["apiUrl"];
            ViewBag.url = url;
            return View();
        }
        public IActionResult Sel()
        {
            string url = _configuration["apiUrl"];
            ViewBag.url = url;
            return View();
        }

        public IActionResult Moban()
        {
            string url = _configuration["apiUrl"];
            ViewBag.url = url;
            return View();
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace OMS.PIGSNey.UI.Controllers
{
    public class TheorderdetailsController : Controller
    {
        private IConfiguration _configuration;

        public TheorderdetailsController(IConfiguration configuration)
        {
            this._configuration = configuration;
        }
        public IActionResult Show()
        {
            string url = _configuration["apiUrl"];
            ViewBag.url = url;
            return View();
        }

        public IActionResult Add()
        {
            string url = _configuration["apiUrl"];
            ViewBag.url = url;
            return View();
        }

        public IActionResult ShowSH()
        {
            string url = _configuration["apiUrl"];
            ViewBag.url = url;
            return View();
        }

    }
}

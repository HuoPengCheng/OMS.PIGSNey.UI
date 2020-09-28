using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace OMS.PIGSNey.UI.Controllers
{

    public class CenterController : Controller
    {
        private IConfiguration _configuration;

        public CenterController(IConfiguration configuration)
        {
            this._configuration = configuration;
        }
        public IActionResult KeHu()
        {
            string url = _configuration["apiUrl"];
            ViewBag.url = url;
            return View();
        }
        public IActionResult WeiXui()
        {
            string url = _configuration["apiUrl"];
            ViewBag.url = url;
            return View();
        }
        public IActionResult ChaoJiGuanLiYuan()
        {
            string url = _configuration["apiUrl"];
            ViewBag.url = url;
            return View();
        }
        public IActionResult Pwd()
        {
            string url = _configuration["apiUrl"];
            ViewBag.url = url;
            return View();
        }
        public IActionResult GuanLi()
        {
            string url = _configuration["apiUrl"];
            ViewBag.url = url;
            return View();
        }
        public IActionResult GeRenWx()
        {
            string url = _configuration["apiUrl"];
            ViewBag.url = url;
            return View();
        }
    }
}

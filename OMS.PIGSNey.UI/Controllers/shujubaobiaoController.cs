using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace OMS.PIGSNey.UI.Controllers
{
    public class shujubaobiaoController : Controller
    {
        public IActionResult Index()//柱形图，饼状图
        {
            return View();
        }
        public IActionResult TouSu()//添加投诉
        {
            return View();
        }

        public IActionResult GetTouSu()//显示
        {
            return View();
        }
    
        public IActionResult WeiXiu()
        {
            return View();
        }
        public IActionResult Ceshi()
        {
            return View();
        }
       

    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace OMS.PIGSNey.UI.Controllers
{
    //数据报表--LDK
    public class QuestionController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
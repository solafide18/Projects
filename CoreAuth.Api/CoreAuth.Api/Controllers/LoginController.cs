using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreAuth.Api.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index(string rUrl)
        {
            //ViewBag.redirectUrl
            return View();
        }
    }
}

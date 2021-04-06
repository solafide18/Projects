using System;
using System.Linq;
using IndoCybreShop.Data;
using IndoCybreShop.Models.TestCandidate;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;

namespace IndoCybreShop.Controllers
{
    public class ProductsController : Controller
    {
        IHostingEnvironment _environment;
        TestCandidateContext _ctx;
        public ProductsController(IHostingEnvironment environment, TestCandidateContext i_ctx)
        {
            _environment = environment;
            _ctx = i_ctx;
        }
        public IActionResult Index()
        {
            var list = _ctx.products.ToList();
            return View(list);
        }

        [HttpPost]
        public IActionResult AddProduct([FromBody] Products req)
        {
            try
            {
                req.CreatedBy = "ADMIN";
                req.CreatedDate = DateTime.Now;
                req.Active = true;
                _ctx.products.Add(req);
                _ctx.SaveChanges();
                return Json(new { remarks = "", status=true });
            }
            catch (Exception e)
            {
                return Json(new { remarks = e.ToString(), status=false });
            }
        }
    }
}
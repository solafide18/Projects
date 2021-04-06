using System.Linq;
using IndoCybreShop.Data;
using IndoCybreShop.Models.ViewModels;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;

namespace IndoCybreShop.Controllers
{
    public class TransaksiController : Controller
    {
        IHostingEnvironment _environment;
        TestCandidateContext _ctx;
        public TransaksiController(IHostingEnvironment environment, TestCandidateContext i_ctx)
        {
            _environment = environment;
            _ctx = i_ctx;
        }

        public IActionResult Index()
        {
            var list = _ctx.orders.ToList();
            return View(list);
        }

        public IActionResult LoadDetails(int id)
        {
            var list = (from a in _ctx.orders
                        join b in _ctx.orderDetails on a.OrderID equals b.OrderID
                        join c in _ctx.products on b.ProductID equals c.ProductID
                        where a.OrderID == id
                        select new OrderDetailViews{
                            ProductID = b.ProductID,
                            ProductName = c.ProductName,
                            UnitPrice = (long)(c.UnitPrice??0),
                            TotalPrice = (long)((c.UnitPrice??0)*b.Quantity),
                            Quantity = b.Quantity,
                            Discount = 0
                        }).ToList();
            ViewBag.totalharga = list.Sum(f=>f.TotalPrice);
            return PartialView("_partialOrderDetails",list);
        }
    }
}
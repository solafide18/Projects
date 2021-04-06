using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using IndoCybreShop.Models;
using Microsoft.AspNetCore.Hosting;
using IndoCybreShop.Data;
using IndoCybreShop.Models.ViewModels;
using IndoCybreShop.Models.TestCandidate;
using IndoCybreShop.Repository;

namespace IndoCybreShop.Controllers
{
    public class HomeController : Controller
    {
        IHostingEnvironment _environment;
        TestCandidateContext _ctx;
        ShopOrdering _repo;
        public HomeController(IHostingEnvironment environment, TestCandidateContext i_ctx)
        {
            _environment = environment;
            _ctx = i_ctx;
            _repo = new ShopOrdering(_ctx);
        }
        // public IActionResult Index()
        // {
        //     HomeReturns model = new HomeReturns();
        //     model.categories =  _ctx.categories.ToList();
        //     model.products = _ctx.products.ToList();
        //     ViewBag.MenuActive = 0;
        //     return View(model);
        // }
        public IActionResult Index()
        {
            var listcustomer = _ctx.customers.ToList();
            ViewBag.listcustomer = listcustomer;
            return View();
        }
        public IActionResult LoadCategories(int id=0)
        {
            ViewBag.categories =  _ctx.categories.ToList();
            ViewBag.MenuActive = id;
            return PartialView("_partialListCategories");
        }
        public IActionResult LoadProducts(int id=0)
        {
            ViewBag.products = _ctx.products.Where(f=>id==0 || f.CategoryID == id).ToList();
            return PartialView("_partialListProduct");
        }
        [HttpPost]
        public IActionResult addItem([FromBody] List<OrderDetailViews> req, int id)
        {
            if(req.Where(f=>f.ProductID == id).ToList().Count()==0)
            {
                var list = _ctx.products.Where(f=>f.ProductID == id).ToList().Select(f=>
                    new OrderDetailViews{
                        ProductID = f.ProductID,
                        ProductName = f.ProductName,
                        UnitPrice = (long)(f.UnitPrice??0),
                        TotalPrice = (long)(f.UnitPrice??0),
                        Quantity = 1,
                        Discount = 0
                }).FirstOrDefault();
                req.Add(list);
            }
            ViewBag.cart = req;
            long totalharga = req.Sum(f=>f.TotalPrice);
            ViewBag.totalharga = totalharga;
            return PartialView("_partialCart");
        }
        [HttpPost]
        public IActionResult BuyItem([FromBody] RequestOrder req)
        {
            try
            {
                string OrderNumber = _repo.generateOrderNumber();
                Orders model = new Orders();
                model.OrderNumber = OrderNumber;
                model.OrderDate = DateTime.Now;
                model.CustomerID = req.CustomerID;
                model.RequiredDate=req.RequiredDate;
                model.ShippedDate=req.ShippedDate;
                model.Freight=req.Freight;
                model.ShipName=req.ShipName;
                model.ShipAddress=req.ShipAddress;
                model.ShipCity=req.ShipCity;
                model.ShipRegion=req.ShipRegion;
                model.ShipPostalCode=req.ShipPostalCode;
                model.ShipCountry=req.ShipCountry;
                _ctx.orders.Add(model);
                _ctx.SaveChanges();
                model = _ctx.orders.Where(f=>f.OrderNumber == OrderNumber).FirstOrDefault();
                foreach (var item in req.list)
                {
                    var productitem = _ctx.products.Where(f=>f.ProductID == item.ProductID).FirstOrDefault();
                    if(productitem!=null)
                    {
                        productitem.UnitsInStock = (short)(productitem.UnitsInStock??0 - item.Quantity);
                        _ctx.products.Update(productitem);
                        _ctx.SaveChanges();
                    }
                    OrderDetails modelDetails = new OrderDetails();
                    modelDetails.Discount = 0;
                    modelDetails.OrderID = model.OrderID;
                    modelDetails.ProductID = item.ProductID;
                    modelDetails.UnitPrice = item.UnitPrice;
                    modelDetails.Quantity = item.Quantity;

                    _ctx.orderDetails.Add(modelDetails);
                    _ctx.SaveChanges();

                    
                }
                return Json(new { remarks="transaksi Berhasil", status = true });
            }
            catch (Exception err)
            {
                return Json(new { remarks=err.ToString(), status = true });
            }
        }
        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }
        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

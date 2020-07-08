using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using assignment1.Models;
using Microsoft.AspNetCore.Mvc;

namespace assignment1.Controllers
{
    public class productController : Controller
    {
        public static List<Product> list = new List<Product>() {
            new Product{pid=1 ,pname="Moto one fusion plus",price=17499,stock=40},
            new Product{pid=2 ,pname="Redmi 8",price=7499,stock=40}

        };
        public IActionResult Index()
        {
            return View(list);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Product p)
        {
            list.Add(p);
            return RedirectToAction("Index");

        }
        public IActionResult Validate(Product prod)
        {
            if (ModelState.IsValid)
            {
                list.Add(prod);
                return RedirectToAction("Index");
            }
            else
                return RedirectToAction("Create");
        }
    }
}

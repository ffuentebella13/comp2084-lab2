using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Lab2.Controllers
{
    public class CategoriesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Details(string product, float price, string category, string details)
        {
            //Store the selected product name
            ViewBag.product = product;
            ViewBag.price = price;
            ViewBag.category = category;
            ViewBag.details = details;
            return View();
        }
    }
}
﻿using Microsoft.AspNetCore.Mvc;

namespace GuitarShop.Controllers
{
    public class CartController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Add(string id)
        {
            //ViewBag.ProductSlug = id;
            //return View();
            TempData["message"] = id + " added to the cart";
            return RedirectToAction("List", "Product");
        }
    }
}

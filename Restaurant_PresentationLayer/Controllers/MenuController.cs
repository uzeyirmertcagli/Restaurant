﻿using Microsoft.AspNetCore.Mvc;

namespace Restaurant_PresentationLayer.Controllers
{
    public class MenuController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

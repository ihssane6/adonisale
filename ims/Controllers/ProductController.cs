﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ims.Controllers
{
    [Authorize(Roles = Pages.MainMenu.Product.RoleName)]
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
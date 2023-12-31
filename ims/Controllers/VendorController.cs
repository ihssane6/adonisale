﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ims.Controllers
{
    [Authorize(Roles = Pages.MainMenu.Vendor.RoleName)]
    public class VendorController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
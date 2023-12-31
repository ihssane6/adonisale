﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ims.Controllers
{
    [Authorize(Roles = Pages.MainMenu.PaymentReceive.RoleName)]
    public class PaymentReceiveController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
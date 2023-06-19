using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ims.Controllers
{
    [Authorize(Roles = Pages.MainMenu.SProduct.RoleName)]
    public class SProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

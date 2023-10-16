using Microsoft.AspNetCore.Mvc;

namespace WebSiteCoreMVC.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult PartialSideBar()
        {
            return PartialView();
        }
    }
}

using Microsoft.AspNetCore.Mvc;

namespace WebSiteCoreMVC.Controllers
{
    public class FeatureController1 : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

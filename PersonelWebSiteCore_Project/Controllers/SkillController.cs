using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace WebSiteCoreMVC.Controllers
{
    public class SkillController : Controller
    {
        SkillManager skillManger = new SkillManager(new EfSkillDal());

        public IActionResult Index()
        {
            var values = skillManger.TGetList();
            return View(values);
        }
    }
}

using Microsoft.AspNetCore.Mvc;

namespace prjAjax.Controllers
{
    public class MemberController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

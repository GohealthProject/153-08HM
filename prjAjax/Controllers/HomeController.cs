using Microsoft.AspNetCore.Mvc;
using prjAjax.Models;
using prjAjax.ViewModels;
using System.Diagnostics;

namespace prjAjax.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly DemoContext _democontext;
         public HomeController(ILogger<HomeController> logger, DemoContext democontext)
        {
            _logger = logger;
            _democontext = democontext;
        }
        public IActionResult first()
        {
            return View();
        }
        public IActionResult Register()
        {
            return View();
        }
        public IActionResult Member()
        {
            return View(_democontext.Members);
        }

        public ActionResult fetch()
        {

            return View();
        }
        public ActionResult promise()
        {

            return View();
        }

        public ActionResult History()
        {

            return View();
        }

        public ActionResult jQuery()
        {

            return View();
        }
        public ActionResult partial1()
        {

            return PartialView();
        }
        public ActionResult partial2()
        {
            ViewBag.message = "partial *  2";
            return PartialView();
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Address()
        {
            return View();
        }
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
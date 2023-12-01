using Microsoft.AspNetCore.Mvc;
using prjAjax.Models;
using prjAjax.ViewModels;
using System.Xml.Linq;

namespace prjAjax.Controllers
{
    public class AjaxController : Controller
    {
        private readonly IWebHostEnvironment _host;
        private readonly DemoContext _context;

        public AjaxController(IWebHostEnvironment host, DemoContext context) {
            _context = context;
            _host=host;
        }
        public IActionResult Index(string name,int?id)
        {
            if (string.IsNullOrEmpty(name)) {

                name = "guest";
            }
            return Content("<h2>hola</h2>","text/html");
        }
        public IActionResult Register(Members memeber,IFormFile fileName) {
            string pathstring = Path.Combine(_host.WebRootPath, "upload", fileName.FileName);
            using (var filestream=new FileStream(pathstring,FileMode.Create)) {
            fileName.CopyTo(filestream);
            
            }
            
            memeber.FileName= fileName.FileName;
            byte[]? bytes = null;
            using (var memorystream =new MemoryStream()) {
            fileName.CopyTo(memorystream);
                bytes= memorystream.ToArray();
            
            }
            memeber.FileData= bytes;
            _context.Members.Add(memeber);
            _context.SaveChanges();
            return Content("新增成功");
            //return Content(pathstring);

            //return Content($"Hello {vm.name}，{vm.email},  You are {vm.age} years old.");


        }

        public IActionResult getImgById(int id=1)
        {
            Members member = _context.Members.Find(id);
            byte[] img = member.FileData;

            if (member!= null) {
                return File(img, "images/png");
            }
           
            return NotFound();
        }


        public IActionResult cities() {

            var city = _context.Address.Select(c => c.city).Distinct();
            return Json(city);
        }
        public IActionResult districts(string city)
        {

            var district = _context.Address.Where(a=>a.city==city).Select(a => a.site_id).Distinct();
            return Json(district);
        }
        public IActionResult roads(string siteID)
        {

            var road = _context.Address.Where(a => a.site_id == siteID).Select(a => a.road).Distinct();
            return Json(road);
        }

    }
}

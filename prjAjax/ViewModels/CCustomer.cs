using Microsoft.Extensions.FileProviders;

namespace prjAjax.ViewModels
{
    public class CCustomer
    {

        public string? name { get; set; }
        public string? email { get; set; }
        public int? age { get; set; }
        public IFormFile? fileName { get; set; }
    }
}

using CoreMVCCodeFirst_1.Models.ContextClasses;
using CoreMVCCodeFirst_1.Models.Entities;
using CoreMVCCodeFirst_1.Models.Products;
using Microsoft.AspNetCore.Mvc;

namespace CoreMVCCodeFirst_1.Controllers
{
    //Product icin fark edeceksiniz ki VM'ler(RequestModel, ResponseModel vs) kısmında Category icin oldugu kadar hassas davranılmamıstır..Bu bilerek sadece simulasyon icin zaman kazanmak adına uyguladıgımız bir taktiktir...Normal şartlarda Category'deki gibi hassas davranılması gerekir...
    public class ProductController : Controller
    {
        MyContext _db;

        public ProductController(MyContext db)
        {
            _db = db;
        }
        public IActionResult GetProducts()
        {
            ProductPageVM pvm = new ProductPageVM()
            {
                Products = _db.Products.ToList()
            };
            return View(pvm);
        }

        public IActionResult CreateProduct()
        {
            return View();
        }
    }
}

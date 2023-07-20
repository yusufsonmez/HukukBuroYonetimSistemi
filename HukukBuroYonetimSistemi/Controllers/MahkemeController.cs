using HukukBuroYonetimSistemi.Models.Domain;
using Microsoft.AspNetCore.Mvc;

namespace HukukBuroYonetimSistemi.Controllers
{
    public class MahkemeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Kaydet(Mahkemeler model)
        {
            // Verileri model üzerinden alın ve istediğiniz işlemleri yapın

            // Örneğin, Mahkeme verisini alalım:
            //_mahkemeService.Kaydet(model);
            string mahkeme = model.Mahkeme;

            // Diğer verileri de alabilirsiniz ve kullanabilirsiniz.

            // İşlemler tamamlandıktan sonra istediğiniz bir sayfaya yönlendirin veya başka bir işlem yapın
            return RedirectToAction("Index");
        }
    }
}

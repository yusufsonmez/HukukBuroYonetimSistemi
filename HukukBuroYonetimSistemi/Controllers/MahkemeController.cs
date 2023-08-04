using BaseProject.Services;
using HukukBuroYonetimSistemi.Models.Domain;
using HukukBuroYonetimSistemi.Models.View;
using Microsoft.AspNetCore.Mvc;

namespace HukukBuroYonetimSistemi.Controllers
{
    public class MahkemeController : Controller
    {
        private readonly MahkemeService _mahkemeService;
        public MahkemeController(MahkemeService mahkemeService)
        {
            _mahkemeService = mahkemeService;
        }
        public IActionResult Index()
        {
            //MahkemelerWebViews gelecek buraya
            var mahkemeViews = _mahkemeService.GetMahkemeViews();
            
            // Değerleri almak için tuple'dan ayrıştırın
            List<MahkemelerWebViews> mahkemeWebViews = mahkemeViews.Item1;
            List<ValuesForMahkemeWebViews> values = mahkemeViews.Item2;

            //mahkemeEkleViewModel = mahkemeViews.Item1;
            MahkemeEkleViewModel mahkemeEkleViewModel   = new MahkemeEkleViewModel();
            mahkemeEkleViewModel.MahkemelerWebViews = mahkemeWebViews;
            mahkemeEkleViewModel.MahkemelerWebViewsValues = values;

            return View(mahkemeEkleViewModel);
        }

        [HttpPost]
        public IActionResult Kaydet(Mahkemeler model)
        {
            // Verileri model üzerinden alın ve istediğiniz işlemleri yapın

            // Örneğin, Mahkeme verisini alalım:
            _mahkemeService.Kaydet(model);
            string mahkeme = model.YargiBirimi;

            // Diğer verileri de alabilirsiniz ve kullanabilirsiniz.

            // İşlemler tamamlandıktan sonra istediğiniz bir sayfaya yönlendirin veya başka bir işlem yapın
            return RedirectToAction("Index", "Dashboard");
        }
        public List<Mahkemeler> GetMahkemelerByUserId(int userId)
        {
            var mahkemeler = _mahkemeService.GetMahkemelerByUserId(userId);
            return mahkemeler;
        }
    }
}

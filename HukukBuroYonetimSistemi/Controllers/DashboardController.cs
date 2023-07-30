using BaseProject.Services;
using HukukBuroYonetimSistemi.Data;
using HukukBuroYonetimSistemi.Models.Domain;
using HukukBuroYonetimSistemi.Models.View;
using Microsoft.AspNetCore.Mvc;

namespace HukukBuroYonetimSistemi.Controllers
{
    public class DashboardController : Controller
    {
        private readonly MahkemeService _mahkemeService;
        private readonly UserService _userService;
        public DashboardController(MahkemeService mahkemeService
            , UserService userService
            )
        {
            _mahkemeService = mahkemeService;
            _userService = userService;
        }

        public IActionResult Index()
        {
            var mahkemeler = _mahkemeService.GetMahkemeler();
            var users = _userService.GetUsers();

            GorevAtamalarViewModel gorevAtamalarViewModel = new GorevAtamalarViewModel
            {
                Mahkemeler = mahkemeler,
                Users = users
            };

            return View(gorevAtamalarViewModel);
        }
    }
}

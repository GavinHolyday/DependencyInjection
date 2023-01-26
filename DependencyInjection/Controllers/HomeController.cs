using DependencyInjection.Services;
using Microsoft.AspNetCore.Mvc;

namespace DependencyInjection.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ISingletonService _singletonService;

        public HomeController(
            ILogger<HomeController> logger,
            ISingletonService singletonService)
        {
            _logger = logger;
            _singletonService = singletonService;
        }

        public IActionResult Index()
        {
            ViewBag.TransientInSingletonFromConstructor = "Transient In Singleton From Constructor " + _singletonService.GetIdFromConstructor().ToString();
            ViewBag.TransientInSingletonFromFactory = "Transient In Singleton From Factory " + _singletonService.GetIdFromFactory().ToString();
            return View();
        }
    }
}
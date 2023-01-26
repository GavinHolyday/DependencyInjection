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
            ViewBag.TransientInSingletonFromProvider = "Transient In Singleton From Provider " + _singletonService.GetIdFromProvider().ToString();
            return View();
        }
    }
}
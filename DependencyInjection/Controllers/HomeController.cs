using DependencyInjection.Services;
using Microsoft.AspNetCore.Mvc;

namespace DependencyInjection.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ISingletonService _singletonService;
        private readonly ITransientService _transientService;

        public HomeController(
            ILogger<HomeController> logger,
            ISingletonService singletonService,
            ITransientService transientService)
        {
            _logger = logger;
            _singletonService = singletonService;
            _transientService = transientService;
        }

        public IActionResult Index()
        {
            ViewBag.TransientInSingleton = "Transient In Singleton " + _singletonService.GetId().ToString();
            return View();
        }
    }
}
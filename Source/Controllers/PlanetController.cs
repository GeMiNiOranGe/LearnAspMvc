using Microsoft.AspNetCore.Mvc;
using Source.Models;
using Source.Services;

namespace Source.Controllers {
    public class PlanetController : Controller {
        private readonly ILogger<PlanetController> _logger;
        private readonly PlanetService _planetService;

        public PlanetController(ILogger<PlanetController> logger, PlanetService planetService) {
            _logger = logger;
            _planetService = planetService;
        }

        [Route("ListOfPlanets")]
        public IActionResult Index() {
            return View();
        }

        [Route("PlanetDetail/{id:int}")]
        public IActionResult Detail(int id) {
            var planetModel = _planetService
                .Where(planet => planet.Id == id)
                .FirstOrDefault();
            return View(planetModel);
        }

        [HttpGet("PlanetDetail/{name}")]
        public IActionResult Detail(string name) {
            var planetModel = _planetService
                .Where(planet => planet.Name == name)
                .FirstOrDefault();
            return View(planetModel);
        }
    }
}

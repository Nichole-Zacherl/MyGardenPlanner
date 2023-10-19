using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyGardenPlanner.Data;
using MyGardenPlanner.Models;

namespace MyGardenPlanner.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PlantController : ControllerBase
    {
        private readonly GardenContext _context;
        public PlantController(GardenContext gardenContext)
        {
            _context = gardenContext;
        }
        [HttpGet]
        public ActionResult<IEnumerable<Plant>> Get()
        {
            return _context.Plant;
        }
    }
}

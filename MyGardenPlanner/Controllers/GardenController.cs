using MyGardenPlanner.Data;
using MyGardenPlanner.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MyGardenPlanner.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GardenController : ControllerBase
    {
        private readonly GardenContext _context;
        public GardenController(GardenContext gardenContext)
        {
            _context = gardenContext;
        }
        [HttpGet]
        public ActionResult<IEnumerable<Garden>> Get()
        {
            return _context.Garden;
        }
    }
}
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyGardenPlanner.Data;
using MyGardenPlanner.Models;

namespace MyGardenPlanner.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PlantCategoryController : ControllerBase
    {
        private readonly GardenContext _context;
        public PlantCategoryController(GardenContext gardenContext)
        {
            _context = gardenContext;
        }
        [HttpGet]
        public ActionResult<IEnumerable<PlantCategory>> Get()
        {
            return _context.PlantCategory;
        }
    }
}
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MyGardenPlanner.Data;
using MyGardenPlanner.Models;

namespace MyGardenPlanner.Server.BE.Controllers
{
    public class BaseController : ControllerBase
    { 
       private readonly GardenContext _context;
        public BaseController(GardenContext gardenContext)
        {
            _context = gardenContext;
        }

        //TO DO:
        //Finish this and impliment to other controllers.

        [HttpGet("{id}")]
        public ActionResult<IEnumerable<Plant>> GetById()
        {
            return _context.Plant;
        }

        [HttpGet("GetAll")]
        public ActionResult<Garden> GetAll()
        {
            throw new NotImplementedException();
        }

        [HttpPut]
        public ActionResult<Garden> Put()
        {
            throw new NotImplementedException();
        }

        [HttpPost]
        public ActionResult<Garden> Post()
        {
            throw new NotImplementedException();
        }

        [HttpDelete]
        public ActionResult<Garden> Delete()
        {
            throw new NotImplementedException();
        }
    }
}

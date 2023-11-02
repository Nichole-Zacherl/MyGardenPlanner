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


        [HttpGet("{id}")]
        public ActionResult<IEnumerable<Garden>> Get()
        {
            return _context.Garden;
        }

        [HttpGet]

        public List<Garden> GetAll()
        {
            List<Garden> gardenList = new List<Garden>
            {
                new Garden{Id="101",Name="Abhinav",Description="Bangalore",Length=40.00,Width=15.00},
                new Garden{Id="102",Name="Abhishek",Description="Chennai",Length=30.00,Width=25.00},
                new Garden{Id="103",Name="Akshay",Description="Bangalore",Length=45.00,Width=15.00},
                new Garden{Id="104",Name="Akash",Description="Chennai",Length=20.00,Width=35.00},
                new Garden{Id="105",Name="Anil",Description="Bangalore",Length=10.00,Width=15.00}
            };
            return gardenList;
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
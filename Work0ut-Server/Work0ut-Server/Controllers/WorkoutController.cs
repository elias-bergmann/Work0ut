using Microsoft.AspNetCore.Mvc;
using Work0ut.Model;
using Work0ut.Utils;

namespace Work0ut.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WorkoutController : ControllerBase
    {
        private readonly ILogger<WorkoutController> _logger;

        public WorkoutController(ILogger<WorkoutController> logger)
        {
            _logger = logger;
        }


        [HttpGet(Name = Methods.GetWorkoutsName)]
        public IEnumerable<Workout> Get()
        {
            return new List<Workout>();
        }
    }
}
using Microsoft.AspNetCore.Mvc;
using Work0ut.Model;
using Work0ut.Service;
using Work0ut.Utils;

namespace Work0ut.Controllers
{
    [ApiController]
    [Route(Utils.Controllers.Workout_ControllerName + "/[action]")]
    public class WorkoutController : ControllerBase
    {
        private readonly DatabaseConnectionService _databaseConnectionService;

        public WorkoutController(DatabaseConnectionService databaseService) => _databaseConnectionService = databaseService;


        [HttpGet(Name = Methods.GetWorkoutsList_MethodName)]
        public async Task<IEnumerable<Workout>> GetWorkoutsList() => await _databaseConnectionService.GetAllWorkoutAsync();



        [HttpGet(Name = Methods.GetWorkoutById_MethodName)]
        public Workout GetWorkoutById()
        {
            return new Workout();
        }
    }
}
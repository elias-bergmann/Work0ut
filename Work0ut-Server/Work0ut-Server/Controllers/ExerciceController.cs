using Microsoft.AspNetCore.Mvc;
using Work0ut.Model;
using Work0ut.Utils;

namespace Work0ut.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ExerciceController : ControllerBase
    {

        private readonly ILogger<ExerciceController> _logger;

        public ExerciceController(ILogger<ExerciceController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = Methods.GetExercicesName)]
        public IEnumerable<Exercice> Get()
        {
            return new List<Exercice>();
        }
    }
}
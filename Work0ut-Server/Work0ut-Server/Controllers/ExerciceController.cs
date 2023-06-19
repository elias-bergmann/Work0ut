using Microsoft.AspNetCore.Mvc;
using Work0ut.Model;
using Work0ut.Service;
using Work0ut.Utils;

namespace Work0ut.Controllers
{
    [ApiController]
    [Route(Utils.Controllers.Movement_ControllerName + "/[action]")]
    public class MovementController : ControllerBase
    {
        private readonly DatabaseConnectionService _databaseConnectionService;

        public MovementController(DatabaseConnectionService databaseService) => _databaseConnectionService = databaseService;

        [HttpGet]
        [ActionName(Methods.GetMovementList_MethodName)]
        public async Task<List<Movement>> Get() => await _databaseConnectionService.GetAllMovementAsync();

        [HttpGet("{id:length(24)}")]
        [ActionName(Methods.GetMovementById_MethodName)]
        public async Task<ActionResult<Movement>> Get(string id)
        {
            var exercice = await _databaseConnectionService.GetMovementAsync(id);

            if (exercice is null)
            {
                return NotFound();
            }

            return exercice;
        }

        [HttpPost]
        [ActionName(Methods.PostNewMovement_MethodName)]
        public async Task<IActionResult> Post(Movement newMovement)
        {
            await _databaseConnectionService.CreateMovementAsync(newMovement);

            return CreatedAtAction(nameof(Get), new { id = newMovement.Id }, newMovement);
        }

        [HttpPut("{id:length(24)}")]
        [ActionName(Methods.PutExistingMovement_MethodName)]
        public async Task<IActionResult> Update(string id, Movement updatedMovement)
        {
            var movement = await _databaseConnectionService.GetMovementAsync(id);

            if (movement is null)
            {
                return NotFound();
            }

            updatedMovement.Id = movement.Id;

            await _databaseConnectionService.UpdateMovementAsync(id, updatedMovement);

            return NoContent();
        }

        [HttpDelete("{id:length(24)}")]
        [ActionName(Methods.DeleteMovementById_MethodName)]
        public async Task<IActionResult> Delete(string id)
        {
            var exercice = await _databaseConnectionService.GetMovementAsync(id);

            if (exercice is null)
            {
                return NotFound();
            }

            await _databaseConnectionService.RemoveMovementAsync(id);

            return NoContent();
        }
    }
}
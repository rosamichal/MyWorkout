using Microsoft.AspNetCore.Mvc;
using MyWorkout.Application.Common.Wrappers;
using MyWorkout.Application.Features.WorkoutPlans.Commands.CreateWorkoutPlan;
using MyWorkout.Application.Features.WorkoutPlans.Commands.DeleteWorkoutPlan;
using MyWorkout.Application.Features.WorkoutPlans.Commands.UpdateWorkoutPlan;
using MyWorkout.Application.Features.WorkoutPlans.Queries.GetAllWorkoutPlans;
using MyWorkout.Application.Features.WorkoutPlans.Queries.GetWorkoutPlanDetail;

namespace MyWorkout.Api.Controllers
{
    [Route("api/workout-plans")]
    public class WorkoutPlanController : BaseController
    {
        /// <summary>
        /// Get all workout plans
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<ApiResponse<List<WorkoutPlanListItemViewModel>>>> GetAll()
        {
            var result = await Mediator.Send(new GetAllWorkoutPlansQuery());

            return Ok(result);
        }

        /// <summary>
        /// Get workout plan by id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound, Type = typeof(ApiResponse<object>))]
        public async Task<ActionResult<ApiResponse<WorkoutPlanDetailViewModel>>> GetWorkoutDetail(int id)
        {
            var result = await Mediator.Send(new GetWorkoutPlanDetailQuery());

            if (result is null)
            {
                return NotFound();
            }

            return Ok(result);
        }

        /// <summary>
        /// Create new workout plan
        /// </summary>
        /// <param name="command"></param>
        /// <returns></returns>
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created, Type = typeof(ApiResponse<int>))]
        public async Task<ActionResult> CreateWorkoutPlan(CreateWorkoutPlanCommand command)
        {
            var result = await Mediator.Send(command);
            return Created($"api/workout-plans/{result.Data}", result);
        }

        /// <summary>
        /// Update workout plan
        /// </summary>
        /// <param name="id"></param>
        /// <param name="command"></param>
        /// <returns></returns>
        [HttpPut("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status409Conflict, Type = typeof(ApiResponse<object>))]
        public async Task<ActionResult> UpdateWorkoutPlan(int id, UpdateWorkoutPlanCommand command)
        {
            if (id != command.WorkoutPlnId)
            {
                return Conflict(ApiResponse<object>.Fail("Conflict."));
            }
            await Mediator.Send(command);
            return NoContent();
        }

        /// <summary>
        /// Delete Workout plan by id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpDelete("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        public async Task<ActionResult> DeleteWorkoutPlan(int id)
        {
            await Mediator.Send(new DeleteWorkoutPlanCommand { WorkoutPlanId = id });
            return NoContent();
        }
    }
}

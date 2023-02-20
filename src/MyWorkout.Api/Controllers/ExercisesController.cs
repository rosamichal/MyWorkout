using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

using MyWorkout.Application.Common.Wrappers;
using MyWorkout.Application.Features.Exercises.Queries.GetAllExercises;

namespace MyWorkout.Api.Controllers
{
    [Route("api/exercises")]
    public class ExercisesController : BaseController
    {
        /// <summary>
        /// Returns all exercises for dropdown list
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public async Task<ActionResult<ApiResponse<List<ExerciseListItemViewModel>>>> GetAll()
        {
            var result = await Mediator.Send(new GetAllExercisesQuery());

            return Ok(result);
        }
    }
}

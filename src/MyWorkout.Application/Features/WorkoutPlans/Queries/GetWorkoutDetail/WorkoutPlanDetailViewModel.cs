using MyWorkout.Application.Common.Mappings;
using MyWorkout.Domain.Entities;

namespace MyWorkout.Application.Features.WorkoutPlans.Queries.GetWorkoutDetail
{
    public class WorkoutPlanDetailViewModel : IMapFrom<WorkoutPlan>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public List<Exercise> Exercises { get; private set; } = new List<Exercise>();
    }
}

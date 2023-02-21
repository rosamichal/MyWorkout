using MyWorkout.Application.Common.Mappings;
using MyWorkout.Application.Features.WorkoutPlans.Queries.GetWorkoutPlanDetail.Dtos;
using MyWorkout.Domain.Entities;

namespace MyWorkout.Application.Features.WorkoutPlans.Queries.GetWorkoutPlanDetail
{
    public class WorkoutPlanDetailViewModel : IMapFrom<WorkoutPlan>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public WorkoutScheduleDto Schedule { get; set; }
        public List<WorkoutPlanTrainingSeriesDto> Series { get; private set; } = new List<WorkoutPlanTrainingSeriesDto>();
    }
}

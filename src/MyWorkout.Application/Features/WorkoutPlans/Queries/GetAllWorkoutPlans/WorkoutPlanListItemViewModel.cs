using AutoMapper;

using MyWorkout.Application.Common.Mappings;
using MyWorkout.Application.Features.WorkoutPlans.Queries.GetWorkoutPlanDetail.Dtos;
using MyWorkout.Domain.Entities;

namespace MyWorkout.Application.Features.WorkoutPlans.Queries.GetAllWorkoutPlans
{
    public class WorkoutPlanListItemViewModel : IMapFrom<WorkoutPlan>
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<WorkoutPlan, WorkoutPlanListItemViewModel>();
        }
    }
}

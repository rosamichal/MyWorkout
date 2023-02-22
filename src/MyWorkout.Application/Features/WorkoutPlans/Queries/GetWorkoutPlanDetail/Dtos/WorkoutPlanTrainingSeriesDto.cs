using AutoMapper;

using MyWorkout.Application.Common.Mappings;
using MyWorkout.Domain.Entities;

namespace MyWorkout.Application.Features.WorkoutPlans.Queries.GetWorkoutPlanDetail.Dtos
{
    public class WorkoutPlanTrainingSeriesDto : IMapFrom<WorkoutPlanTrainingSeries>
    {
        public string? Name { get; set; }
        public int RestTimeBetweenExercisesInSecond { get; set; }
        public int RestTimeBetweenSeriesInSecond { get; set; }
        public List<WorkoutPlanExerciseDto> Exercises { get; set; } = new List<WorkoutPlanExerciseDto>();

        public void Mapping(Profile profile)
        {
            profile.CreateMap<WorkoutPlanTrainingSeries, WorkoutPlanTrainingSeriesDto>();
        }
    }
}

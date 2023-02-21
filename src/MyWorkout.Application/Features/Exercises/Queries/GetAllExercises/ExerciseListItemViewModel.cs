using AutoMapper;

using MyWorkout.Application.Common.Mappings;
using MyWorkout.Application.Features.WorkoutPlans.Queries.GetWorkoutPlanDetail.Dtos;
using MyWorkout.Domain.Entities;

namespace MyWorkout.Application.Features.Exercises.Queries.GetAllExercises
{
    public class ExerciseListItemViewModel : IMapFrom<Exercise>
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<Exercise, ExerciseListItemViewModel>();
        }
    }
}

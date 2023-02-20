using AutoMapper;

using MyWorkout.Application.Common.Mappings;
using MyWorkout.Domain.Entities;

namespace MyWorkout.Application.Features.Exercises.Queries.GetAllExercises
{
    public class ExerciseListItemViewModel : IMapFrom<Exercise>
    {
        public int ExerciseId { get; set; }
        public string Name { get; set; }
    }
}

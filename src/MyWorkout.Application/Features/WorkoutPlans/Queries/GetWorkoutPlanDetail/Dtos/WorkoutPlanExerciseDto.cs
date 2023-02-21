using AutoMapper;

using MyWorkout.Application.Common.Mappings;
using MyWorkout.Domain.Entities;

namespace MyWorkout.Application.Features.WorkoutPlans.Queries.GetWorkoutPlanDetail.Dtos
{
    public class WorkoutPlanExerciseDto : IMapFrom<WorkoutPlanExercise>
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Type { get; set; }
        public bool IsTimeExercise { get; set; }
        public int? NumberOfRepetitions { get; set; }
        public int? TimeInSecond { get; set; }
        public decimal? WeightInKilograms { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<WorkoutPlanExercise, WorkoutPlanExerciseDto>().ForMember(dest => dest.Type, option => option.MapFrom(src => src.Type.Name));
        }
    }
}

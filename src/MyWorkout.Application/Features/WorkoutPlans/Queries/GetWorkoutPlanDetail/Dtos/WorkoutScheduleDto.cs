using MyWorkout.Application.Common.Mappings;
using MyWorkout.Domain.Entities;

namespace MyWorkout.Application.Features.WorkoutPlans.Queries.GetWorkoutPlanDetail.Dtos
{
    public class WorkoutScheduleDto : IMapFrom<WorkoutSchedule>
    {
        public bool IsPeriod { get; set; }
        public int? PeriodValue { get; set; }
        public bool? Monday { get; set; }
        public bool? Tuesday { get; set; }
        public bool? Wednesday { get; set; }
        public bool? Thursday { get; set; }
        public bool? Friday { get; set; }
        public bool? Saturday { get; set; }
        public bool? Sunday { get; set; }
    }
}

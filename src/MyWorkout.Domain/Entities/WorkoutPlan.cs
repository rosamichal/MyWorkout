using MyWorkout.Domain.Common;

namespace MyWorkout.Domain.Entities
{
    public class WorkoutPlan : AuditableEntity
    {
        public string Name { get; set; }
        public string? Description { get; set; }
        public List<WorkoutPlanTrainingSeries> Series { get; private set; } = new List<WorkoutPlanTrainingSeries>();
        public int ScheduleId { get; set; }
        public WorkoutSchedule Schedule { get; set; }
    }
}

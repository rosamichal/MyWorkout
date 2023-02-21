using MyWorkout.Domain.Common;

namespace MyWorkout.Domain.Entities
{
    public class Workout : AuditableEntity
    {
        public WorkoutPlan WorkoutPlan { get; set; }
        public DateTime WorkoutDate { get; set; }
        public List<WorkoutTrainingSeries> Series { get; private set; } = new List<WorkoutTrainingSeries>();
        public string Note { get; set; }
    }
}

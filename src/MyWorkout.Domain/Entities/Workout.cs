using MyWorkout.Domain.Common;

namespace MyWorkout.Domain.Entities
{
    public class Workout : AuditableEntity
    {
        public WorkoutPlan WorkoutPlan { get; set; }
        public DateTime WorkoutDate { get; set; }
        public List<WorkoutExercise> Exercises { get; private set; } = new List<WorkoutExercise>();
        public string Note { get; set; }
    }
}

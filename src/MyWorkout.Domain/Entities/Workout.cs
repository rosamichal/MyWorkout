using MyWorkout.Domain.Common;

namespace MyWorkout.Domain.Entities
{
    public class Workout : AuditableEntity
    {
        public WorkoutPlan WorkoutPlan { get; set; }
        public DateTime Date { get; set; }
        public List<Exercise> Exercises { get; private set; } = new List<Exercise>();
        public string Note { get; set; }
    }
}

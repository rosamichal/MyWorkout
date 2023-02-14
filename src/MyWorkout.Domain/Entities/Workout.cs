using MyWorkout.Domain.Common;

namespace MyWorkout.Domain.Entities
{
    internal class Workout : AuditableEntity
    {
        public WorkoutPlan WorkoutPlan { get; set; }
        public DateTime Date { get; set; }
        public ICollection<Exercise> Exercises { get; set; }
        public string Note { get; set; }
    }
}

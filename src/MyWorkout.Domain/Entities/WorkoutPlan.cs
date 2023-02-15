using MyWorkout.Domain.Common;

namespace MyWorkout.Domain.Entities
{
    public class WorkoutPlan : AuditableEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public List<Exercise> Exercises { get; private set; } = new List<Exercise>();

    }
}

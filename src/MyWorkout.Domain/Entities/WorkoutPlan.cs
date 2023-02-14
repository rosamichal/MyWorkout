using MyWorkout.Domain.Common;

namespace MyWorkout.Domain.Entities
{
    internal class WorkoutPlan : AuditableEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public ICollection<Exercise> Exercises { get; set; }

    }
}

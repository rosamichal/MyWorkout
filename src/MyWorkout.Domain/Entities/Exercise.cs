using MyWorkout.Domain.Common;

namespace MyWorkout.Domain.Entities
{
    internal class Exercise : AuditableEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int TypeId { get; set; }
        public ExerciseType Type { get; set; }
        public ICollection<Workout> Workouts { get; set; }
        public ICollection<WorkoutPlan> WorkoutPlans { get; set; }
    }
}

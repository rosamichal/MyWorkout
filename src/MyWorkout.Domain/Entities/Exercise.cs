using MyWorkout.Domain.Common;

namespace MyWorkout.Domain.Entities
{
    public class Exercise : AuditableEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int TypeId { get; set; }
        public ExerciseType Type { get; set; }
        public List<Workout> Workouts { get; private set; } = new List<Workout>();
        public List<WorkoutPlan> WorkoutPlans { get; private set; } = new List<WorkoutPlan>();
    }
}

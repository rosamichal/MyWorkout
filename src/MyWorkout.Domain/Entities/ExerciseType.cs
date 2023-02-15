using MyWorkout.Domain.Common;

namespace MyWorkout.Domain.Entities
{
    public class ExerciseType : AuditableEntity
    {
        public string Name { get; set; }
        public List<Exercise> Exercises { get; private set; } = new List<Exercise>();
    }
}

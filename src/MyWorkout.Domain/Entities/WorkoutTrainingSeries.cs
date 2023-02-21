using MyWorkout.Domain.Common;

namespace MyWorkout.Domain.Entities
{
    public class WorkoutTrainingSeries : AuditableEntity
    {
        public string Name { get; set; }
        public int RestTimeBetweenExercisesInSecond { get; set; }
        public int RestTimeBetweenSeriesInSecond { get; set; }
        public List<WorkoutExercise> Exercises { get; set; } = new List<WorkoutExercise>();
    }
}

using MyWorkout.Domain.Common;

namespace MyWorkout.Domain.Entities
{
    public class WorkoutPlanTrainingSeries : AuditableEntity
    {
        public string Name { get; set; }
        public int RestTimeBetweenExercisesInSecond { get; set; }
        public int RestTimeBetweenSeriesInSecond { get; set; }
        public List<WorkoutPlanExercise> Exercises { get; set; } = new List<WorkoutPlanExercise>();
    }
}

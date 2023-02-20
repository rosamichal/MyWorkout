using MyWorkout.Domain.Common;

namespace MyWorkout.Domain.Entities
{
    public class WorkoutPlanExercise : AuditableEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int TypeId { get; set; }
        public ExerciseType Type { get; set; }
        public int WorkoutPlanId { get; set; }
        public WorkoutPlan WorkoutPlan { get; set; }
        public bool IsTimeExercise { get; set; }
        public int? NumberOfRepetitions { get; set; }
        public int? TimeInSecond { get; set; }
        public decimal? WeightInKilograms { get; set; }
    }
}

using MyWorkout.Domain.Common;

namespace MyWorkout.Domain.Entities
{
    public class WorkoutExercise : AuditableEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int TypeId { get; set; }
        public ExerciseType Type { get; set; }
        public int WorkoutTrainingSeriesId { get; set; }
        public WorkoutTrainingSeries Series { get; set; }
        public bool IsTimeExercise { get; set; }
        public int? NumberOfRepetitions { get; set; }
        public int? NumberOfRepetitionsDone { get; set; }
        public int? TimeInSecond { get; set; }
        public int? TimeInSecondDone { get; set; }
        public decimal? WeightInKilograms { get; set; }

    }
}

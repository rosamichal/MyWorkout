namespace MyWorkout.Domain.Entities
{
    internal class ExerciseType
    {
        public string Name { get; set; }
        public ICollection<Exercise> Exercises { get; set; }
    }
}

namespace MyWorkout.Domain.Entities
{
    internal class ExerciseType
    {
        public string Name { get; set; }
        public List<Exercise> Exercises { get; private set; } = new List<Exercise>();
    }
}

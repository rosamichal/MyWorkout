using Microsoft.EntityFrameworkCore;

using MyWorkout.Domain.Entities;

namespace MyWorkout.Persistance
{
    internal static class Seed
    {
        public static void SeedData(this ModelBuilder modelBuilder)
        {
            var seedDate = DateTime.Now;

            modelBuilder.Entity<ExerciseType>(t =>
            {
                t.HasData(
                    new ExerciseType { Id = 1, Created = seedDate, CreatedBy = "Michał", IsDeleted = false, Name = "Ćwiczenia na plecy" },
                    new ExerciseType { Id = 2, Created = seedDate, CreatedBy = "Michał", IsDeleted = false, Name = "Ćwiczenia na klatkę" },
                    new ExerciseType { Id = 3, Created = seedDate, CreatedBy = "Michał", IsDeleted = false, Name = "Ćwiczenia na nogi" },
                    new ExerciseType { Id = 4, Created = seedDate, CreatedBy = "Michał", IsDeleted = false, Name = "Ćwiczenia na barki" },
                    new ExerciseType { Id = 5, Created = seedDate, CreatedBy = "Michał", IsDeleted = false, Name = "Ćwiczenia na biceps" },
                    new ExerciseType { Id = 6, Created = seedDate, CreatedBy = "Michał", IsDeleted = false, Name = "Ćwiczenia na triceps" },
                    new ExerciseType { Id = 7, Created = seedDate, CreatedBy = "Michał", IsDeleted = false, Name = "Ćwiczenia na core" },
                    new ExerciseType { Id = 8, Created = seedDate, CreatedBy = "Michał", IsDeleted = false, Name = "Ćwiczenia na całe ciało/wielostawowe" },
                    new ExerciseType { Id = 9, Created = seedDate, CreatedBy = "Michał", IsDeleted = false, Name = "Ćwiczenia kardio" }
                    );
            });

            modelBuilder.Entity<Exercise>(t =>
            {
                t.HasData(
                    new Exercise { Id = 1, Created = seedDate, CreatedBy = "Michał", IsDeleted = false, Name = "Pompki klasyczne", TypeId = 2 },
                    new Exercise { Id = 2, Created = seedDate, CreatedBy = "Michał", IsDeleted = false, Name = "Pompki na barki", TypeId = 2 },
                    new Exercise { Id = 3, Created = seedDate, CreatedBy = "Michał", IsDeleted = false, Name = "Pompki wąskie", TypeId = 2 },
                    new Exercise { Id = 4, Created = seedDate, CreatedBy = "Michał", IsDeleted = false, Name = "Podciąganie nachwytem", TypeId = 1 },
                    new Exercise { Id = 5, Created = seedDate, CreatedBy = "Michał", IsDeleted = false, Name = "Podciąganie podchwytem", TypeId = 1 },
                    new Exercise { Id = 6, Created = seedDate, CreatedBy = "Michał", IsDeleted = false, Name = "Podciąganie australijskie", TypeId = 1 },
                    new Exercise { Id = 7, Created = seedDate, CreatedBy = "Michał", IsDeleted = false, Name = "Przysiady klasyczne", TypeId = 3 },
                    new Exercise { Id = 8, Created = seedDate, CreatedBy = "Michał", IsDeleted = false, Name = "Przysiady na jednej nodze", TypeId = 3 },
                    new Exercise { Id = 9, Created = seedDate, CreatedBy = "Michał", IsDeleted = false, Name = "Przysiady bułgarskie", TypeId = 3 },
                    new Exercise { Id = 10, Created = seedDate, CreatedBy = "Michał", IsDeleted = false, Name = "Martwy ciąg", TypeId = 8 },
                    new Exercise { Id = 11, Created = seedDate, CreatedBy = "Michał", IsDeleted = false, Name = "Deska na przedramionach", TypeId = 7 },
                    new Exercise { Id = 12, Created = seedDate, CreatedBy = "Michał", IsDeleted = false, Name = "Burpees", TypeId = 9 }
                    );
            });

            modelBuilder.Entity<WorkoutSchedule>(t =>
            {
                t.HasData(new WorkoutSchedule { Id = 1, Created = seedDate, CreatedBy = "Michał", IsDeleted = false, IsPeriod = true, PeriodDays = 2});
            });

            modelBuilder.Entity<WorkoutPlan>(t =>
            {
                t.HasData(new WorkoutPlan { Id = 1, Created = seedDate, CreatedBy = "Michał", IsDeleted = false, Name = "Mój plan", Description = "Mój pierwszy plan treningoey oparty na ćwiczeniach wielostawowych", ScheduleId = 1});
            });

            modelBuilder.Entity<WorkoutPlanTrainingSeries>(t => 
            {
                t.HasData(
                    new WorkoutPlanTrainingSeries { Id = 1, Created = seedDate, CreatedBy = "Michał", IsDeleted = false, Name = "Rozgrzewka", RestTimeBetweenSeriesInSecond = 30, WorkoutPlanId = 1 },
                    new WorkoutPlanTrainingSeries { Id = 2, Created = seedDate, CreatedBy = "Michał", IsDeleted = false, Name = "Superseria", RestTimeBetweenSeriesInSecond = 180, WorkoutPlanId = 1 },
                    new WorkoutPlanTrainingSeries { Id = 3, Created = seedDate, CreatedBy = "Michał", IsDeleted = false, Name = "Dobitka", RestTimeBetweenSeriesInSecond = 180, WorkoutPlanId = 1 }
                    );
            });

            modelBuilder.Entity<WorkoutPlanExercise>(t =>
            {
                t.HasData(
                    new WorkoutPlanExercise { Id = 1, Created = seedDate, CreatedBy = "Michał", IsDeleted = false, Name = "Burpees", TypeId = 9, IsTimeExercise = true, TimeInSecond = 60, WorkoutPlanTrainingSeriesId = 1 },
                    new WorkoutPlanExercise { Id = 2, Created = seedDate, CreatedBy = "Michał", IsDeleted = false, Name = "Pompki klasyczne", TypeId = 2, IsTimeExercise = false, NumberOfRepetitions = 10, WorkoutPlanTrainingSeriesId = 2 },
                    new WorkoutPlanExercise { Id = 3, Created = seedDate, CreatedBy = "Michał", IsDeleted = false, Name = "Podciąganie nachwytem", TypeId = 1, IsTimeExercise = false, NumberOfRepetitions = 8, WorkoutPlanTrainingSeriesId = 2 },
                    new WorkoutPlanExercise { Id = 4, Created = seedDate, CreatedBy = "Michał", IsDeleted = false, Name = "Martwy ciąg", TypeId = 8, IsTimeExercise = false, NumberOfRepetitions = 10, WeightInKilograms = 70, WorkoutPlanTrainingSeriesId = 3 }
                    );
            });
        }
    }
}

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
                    new Exercise { Id = 1, Created = seedDate, CreatedBy = "Michał", IsDeleted = false, Name = "Przysiady klasyczne", TypeId = 3 },
                    new Exercise { Id = 2, Created = seedDate, CreatedBy = "Michał", IsDeleted = false, Name = "Przysiady na jednej nodze", TypeId = 3 },
                    new Exercise { Id = 3, Created = seedDate, CreatedBy = "Michał", IsDeleted = false, Name = "Przysiady bułgarskie", TypeId = 3 },
                    new Exercise { Id = 4, Created = seedDate, CreatedBy = "Michał", IsDeleted = false, Name = "Martwy ciąg", TypeId = 8 },
                    new Exercise { Id = 5, Created = seedDate, CreatedBy = "Michał", IsDeleted = false, Name = "Deska na przedramionach", TypeId = 7 },
                    new Exercise { Id = 6, Created = seedDate, CreatedBy = "Michał", IsDeleted = false, Name = "Burpees", TypeId = 9 }

                    );
            });
        }
    }
}

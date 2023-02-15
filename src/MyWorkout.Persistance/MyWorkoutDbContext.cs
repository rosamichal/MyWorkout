﻿using Microsoft.EntityFrameworkCore;

using MyWorkout.Domain.Common;
using MyWorkout.Domain.Entities;

namespace MyWorkout.Persistance
{
    internal class MyWorkoutDbContext : DbContext
    {
        public MyWorkoutDbContext(DbContextOptions<MyWorkoutDbContext> options) : base(options)
        {

        }

        public DbSet<Exercise> Exercises { get; set; }
        public DbSet<ExerciseType> ExerciseTypes { get; set; }
        public DbSet<Workout> Workouts { get; set; }
        public DbSet<WorkoutPlan> WorkoutPlans { get; set; }
        public DbSet<WorkoutSchedule> WorkoutSchedules { get; set; }

        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            foreach (var entry in ChangeTracker.Entries<AuditableEntity>())
            {
                switch (entry.State)
                {
                    case EntityState.Added:
                        entry.Entity.CreatedBy = "Michał";
                        entry.Entity.Created = DateTime.Now;
                        entry.Entity.IsDeleted = false;
                        break;
                    case EntityState.Modified:
                        entry.Entity.ModifiedBy = "Michał";
                        entry.Entity.Modified = DateTime.Now;
                        break;
                    case EntityState.Deleted:
                        entry.Entity.ModifiedBy = "Michał";
                        entry.Entity.Modified = DateTime.Now;
                        entry.Entity.DeletedBy = "Michał";
                        entry.Entity.Deleted = DateTime.Now;
                        entry.Entity.IsDeleted = true;
                        entry.State = EntityState.Modified;
                        break;
                }
            }
            return base.SaveChangesAsync(cancellationToken);
        }
    }
}

using Microsoft.EntityFrameworkCore;

using MyWorkout.Application.Common.Interfaces;
using MyWorkout.Domain.Common;
using MyWorkout.Domain.Entities;

using System.Reflection;

namespace MyWorkout.Persistance
{
    internal class MyWorkoutDbContext : DbContext, IMyWorkoutDbContext
    {
        private readonly IDateTime _dateTime;

        public MyWorkoutDbContext(DbContextOptions<MyWorkoutDbContext> options, IDateTime dateTime) : base(options)
        {
            this._dateTime = dateTime;
        }

        public DbSet<Exercise> Exercises { get; set; }
        public DbSet<ExerciseType> ExerciseTypes { get; set; }
        public DbSet<Workout> Workouts { get; set; }
        public DbSet<WorkoutPlan> WorkoutPlans { get; set; }
        public DbSet<WorkoutSchedule> WorkoutSchedules { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

            modelBuilder.SeedData();
        }

        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            foreach (var entry in ChangeTracker.Entries<AuditableEntity>())
            {
                switch (entry.State)
                {
                    case EntityState.Added:
                        entry.Entity.CreatedBy = "Michał";
                        entry.Entity.Created = _dateTime.Now;
                        entry.Entity.IsDeleted = false;
                        break;
                    case EntityState.Modified:
                        entry.Entity.ModifiedBy = "Michał";
                        entry.Entity.Modified = _dateTime.Now;
                        break;
                    case EntityState.Deleted:
                        entry.Entity.ModifiedBy = "Michał";
                        entry.Entity.Modified = _dateTime.Now;
                        entry.Entity.DeletedBy = "Michał";
                        entry.Entity.Deleted = _dateTime.Now;
                        entry.Entity.IsDeleted = true;
                        entry.State = EntityState.Modified;
                        break;
                }
            }
            return base.SaveChangesAsync(cancellationToken);
        }
    }
}

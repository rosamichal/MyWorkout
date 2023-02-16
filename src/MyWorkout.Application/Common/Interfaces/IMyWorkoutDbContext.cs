using Microsoft.EntityFrameworkCore;

using MyWorkout.Domain.Entities;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyWorkout.Application.Common.Interfaces
{
    public interface IMyWorkoutDbContext
    {
        public DbSet<Exercise> Exercises { get; set; }
        public DbSet<ExerciseType> ExerciseTypes { get; set; }
        public DbSet<Workout> Workouts { get; set; }
        public DbSet<WorkoutPlan> WorkoutPlans { get; set; }
        public DbSet<WorkoutSchedule> WorkoutSchedules { get; set; }

        Task<int> SaveChangesAsync(CancellationToken cancellationToken);
    }
}

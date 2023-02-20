using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using MyWorkout.Domain.Entities;

namespace MyWorkout.Persistance.Configurations
{
    internal class WorkoutPlanExerciseConfiguration : IEntityTypeConfiguration<WorkoutPlanExercise>
    {
        public void Configure(EntityTypeBuilder<WorkoutPlanExercise> builder)
        {
            builder.Property(p => p.Name).IsRequired().HasMaxLength(200);
            builder.Property(p => p.Description).HasMaxLength(1000);
        }
    }
}

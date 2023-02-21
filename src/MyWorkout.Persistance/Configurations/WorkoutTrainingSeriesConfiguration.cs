using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using MyWorkout.Domain.Entities;

namespace MyWorkout.Persistance.Configurations
{
    public class WorkoutTrainingSeriesConfiguration : IEntityTypeConfiguration<WorkoutTrainingSeries>
    {
        public void Configure(EntityTypeBuilder<WorkoutTrainingSeries> builder)
        {
            builder.Property(p => p.Name).IsRequired().HasMaxLength(200);
            builder.Property(p => p.RestTimeBetweenExercisesInSecond).IsRequired();
            builder.Property(p => p.RestTimeBetweenSeriesInSecond).IsRequired();
        }
    }
}

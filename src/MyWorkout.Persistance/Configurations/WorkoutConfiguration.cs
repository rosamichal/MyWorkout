using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

using MyWorkout.Domain.Entities;

namespace MyWorkout.Persistance.Configurations
{
    internal class WorkoutConfiguration : IEntityTypeConfiguration<Workout>
    {
        public void Configure(EntityTypeBuilder<Workout> builder)
        {
            builder.Property(p => p.WorkoutDate).IsRequired();
            builder.Property(p => p.Note).HasMaxLength(1000);
        }
    }
}

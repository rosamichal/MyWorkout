﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MyWorkout.Persistance;

#nullable disable

namespace MyWorkout.Persistance.Migrations
{
    [DbContext(typeof(MyWorkoutDbContext))]
    partial class MyWorkoutDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("MyWorkout.Domain.Entities.Exercise", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime2");

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("Deleted")
                        .HasColumnType("datetime2");

                    b.Property<string>("DeletedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .HasMaxLength(1000)
                        .HasColumnType("nvarchar(1000)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("Modified")
                        .HasColumnType("datetime2");

                    b.Property<string>("ModifiedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<int>("TypeId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("TypeId");

                    b.ToTable("Exercises");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Created = new DateTime(2023, 2, 21, 14, 53, 2, 958, DateTimeKind.Local).AddTicks(392),
                            CreatedBy = "Michał",
                            IsDeleted = false,
                            Name = "Pompki klasyczne",
                            TypeId = 2
                        },
                        new
                        {
                            Id = 2,
                            Created = new DateTime(2023, 2, 21, 14, 53, 2, 958, DateTimeKind.Local).AddTicks(392),
                            CreatedBy = "Michał",
                            IsDeleted = false,
                            Name = "Pompki na barki",
                            TypeId = 2
                        },
                        new
                        {
                            Id = 3,
                            Created = new DateTime(2023, 2, 21, 14, 53, 2, 958, DateTimeKind.Local).AddTicks(392),
                            CreatedBy = "Michał",
                            IsDeleted = false,
                            Name = "Pompki wąskie",
                            TypeId = 2
                        },
                        new
                        {
                            Id = 4,
                            Created = new DateTime(2023, 2, 21, 14, 53, 2, 958, DateTimeKind.Local).AddTicks(392),
                            CreatedBy = "Michał",
                            IsDeleted = false,
                            Name = "Podciąganie nachwytem",
                            TypeId = 1
                        },
                        new
                        {
                            Id = 5,
                            Created = new DateTime(2023, 2, 21, 14, 53, 2, 958, DateTimeKind.Local).AddTicks(392),
                            CreatedBy = "Michał",
                            IsDeleted = false,
                            Name = "Podciąganie podchwytem",
                            TypeId = 1
                        },
                        new
                        {
                            Id = 6,
                            Created = new DateTime(2023, 2, 21, 14, 53, 2, 958, DateTimeKind.Local).AddTicks(392),
                            CreatedBy = "Michał",
                            IsDeleted = false,
                            Name = "Podciąganie australijskie",
                            TypeId = 1
                        },
                        new
                        {
                            Id = 7,
                            Created = new DateTime(2023, 2, 21, 14, 53, 2, 958, DateTimeKind.Local).AddTicks(392),
                            CreatedBy = "Michał",
                            IsDeleted = false,
                            Name = "Przysiady klasyczne",
                            TypeId = 3
                        },
                        new
                        {
                            Id = 8,
                            Created = new DateTime(2023, 2, 21, 14, 53, 2, 958, DateTimeKind.Local).AddTicks(392),
                            CreatedBy = "Michał",
                            IsDeleted = false,
                            Name = "Przysiady na jednej nodze",
                            TypeId = 3
                        },
                        new
                        {
                            Id = 9,
                            Created = new DateTime(2023, 2, 21, 14, 53, 2, 958, DateTimeKind.Local).AddTicks(392),
                            CreatedBy = "Michał",
                            IsDeleted = false,
                            Name = "Przysiady bułgarskie",
                            TypeId = 3
                        },
                        new
                        {
                            Id = 10,
                            Created = new DateTime(2023, 2, 21, 14, 53, 2, 958, DateTimeKind.Local).AddTicks(392),
                            CreatedBy = "Michał",
                            IsDeleted = false,
                            Name = "Martwy ciąg",
                            TypeId = 8
                        },
                        new
                        {
                            Id = 11,
                            Created = new DateTime(2023, 2, 21, 14, 53, 2, 958, DateTimeKind.Local).AddTicks(392),
                            CreatedBy = "Michał",
                            IsDeleted = false,
                            Name = "Deska na przedramionach",
                            TypeId = 7
                        },
                        new
                        {
                            Id = 12,
                            Created = new DateTime(2023, 2, 21, 14, 53, 2, 958, DateTimeKind.Local).AddTicks(392),
                            CreatedBy = "Michał",
                            IsDeleted = false,
                            Name = "Burpees",
                            TypeId = 9
                        });
                });

            modelBuilder.Entity("MyWorkout.Domain.Entities.ExerciseType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime2");

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("Deleted")
                        .HasColumnType("datetime2");

                    b.Property<string>("DeletedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("Modified")
                        .HasColumnType("datetime2");

                    b.Property<string>("ModifiedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("ExerciseTypes");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Created = new DateTime(2023, 2, 21, 14, 53, 2, 958, DateTimeKind.Local).AddTicks(392),
                            CreatedBy = "Michał",
                            IsDeleted = false,
                            Name = "Ćwiczenia na plecy"
                        },
                        new
                        {
                            Id = 2,
                            Created = new DateTime(2023, 2, 21, 14, 53, 2, 958, DateTimeKind.Local).AddTicks(392),
                            CreatedBy = "Michał",
                            IsDeleted = false,
                            Name = "Ćwiczenia na klatkę"
                        },
                        new
                        {
                            Id = 3,
                            Created = new DateTime(2023, 2, 21, 14, 53, 2, 958, DateTimeKind.Local).AddTicks(392),
                            CreatedBy = "Michał",
                            IsDeleted = false,
                            Name = "Ćwiczenia na nogi"
                        },
                        new
                        {
                            Id = 4,
                            Created = new DateTime(2023, 2, 21, 14, 53, 2, 958, DateTimeKind.Local).AddTicks(392),
                            CreatedBy = "Michał",
                            IsDeleted = false,
                            Name = "Ćwiczenia na barki"
                        },
                        new
                        {
                            Id = 5,
                            Created = new DateTime(2023, 2, 21, 14, 53, 2, 958, DateTimeKind.Local).AddTicks(392),
                            CreatedBy = "Michał",
                            IsDeleted = false,
                            Name = "Ćwiczenia na biceps"
                        },
                        new
                        {
                            Id = 6,
                            Created = new DateTime(2023, 2, 21, 14, 53, 2, 958, DateTimeKind.Local).AddTicks(392),
                            CreatedBy = "Michał",
                            IsDeleted = false,
                            Name = "Ćwiczenia na triceps"
                        },
                        new
                        {
                            Id = 7,
                            Created = new DateTime(2023, 2, 21, 14, 53, 2, 958, DateTimeKind.Local).AddTicks(392),
                            CreatedBy = "Michał",
                            IsDeleted = false,
                            Name = "Ćwiczenia na core"
                        },
                        new
                        {
                            Id = 8,
                            Created = new DateTime(2023, 2, 21, 14, 53, 2, 958, DateTimeKind.Local).AddTicks(392),
                            CreatedBy = "Michał",
                            IsDeleted = false,
                            Name = "Ćwiczenia na całe ciało/wielostawowe"
                        },
                        new
                        {
                            Id = 9,
                            Created = new DateTime(2023, 2, 21, 14, 53, 2, 958, DateTimeKind.Local).AddTicks(392),
                            CreatedBy = "Michał",
                            IsDeleted = false,
                            Name = "Ćwiczenia kardio"
                        });
                });

            modelBuilder.Entity("MyWorkout.Domain.Entities.Workout", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime2");

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("Deleted")
                        .HasColumnType("datetime2");

                    b.Property<string>("DeletedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("Modified")
                        .HasColumnType("datetime2");

                    b.Property<string>("ModifiedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Note")
                        .HasMaxLength(1000)
                        .HasColumnType("nvarchar(1000)");

                    b.Property<DateTime>("WorkoutDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("WorkoutPlanId")
                        .HasColumnType("int");

                    b.Property<string>("WorkoutPlanName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Workouts");
                });

            modelBuilder.Entity("MyWorkout.Domain.Entities.WorkoutExercise", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime2");

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("Deleted")
                        .HasColumnType("datetime2");

                    b.Property<string>("DeletedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .HasMaxLength(1000)
                        .HasColumnType("nvarchar(1000)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<bool>("IsTimeExercise")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("Modified")
                        .HasColumnType("datetime2");

                    b.Property<string>("ModifiedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<int?>("NumberOfRepetitions")
                        .HasColumnType("int");

                    b.Property<int?>("NumberOfRepetitionsDone")
                        .HasColumnType("int");

                    b.Property<int?>("TimeInSecond")
                        .HasColumnType("int");

                    b.Property<int?>("TimeInSecondDone")
                        .HasColumnType("int");

                    b.Property<int>("TypeId")
                        .HasColumnType("int");

                    b.Property<decimal?>("WeightInKilograms")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("WorkoutTrainingSeriesId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("TypeId");

                    b.HasIndex("WorkoutTrainingSeriesId");

                    b.ToTable("WorkoutExercises");
                });

            modelBuilder.Entity("MyWorkout.Domain.Entities.WorkoutPlan", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime2");

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("Deleted")
                        .HasColumnType("datetime2");

                    b.Property<string>("DeletedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .HasMaxLength(1000)
                        .HasColumnType("nvarchar(1000)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("Modified")
                        .HasColumnType("datetime2");

                    b.Property<string>("ModifiedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<int>("ScheduleId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ScheduleId");

                    b.ToTable("WorkoutPlans");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Created = new DateTime(2023, 2, 21, 14, 53, 2, 958, DateTimeKind.Local).AddTicks(392),
                            CreatedBy = "Michał",
                            Description = "Mój pierwszy plan treningoey oparty na ćwiczeniach wielostawowych",
                            IsDeleted = false,
                            Name = "Mój plan",
                            ScheduleId = 1
                        });
                });

            modelBuilder.Entity("MyWorkout.Domain.Entities.WorkoutPlanExercise", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime2");

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("Deleted")
                        .HasColumnType("datetime2");

                    b.Property<string>("DeletedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .HasMaxLength(1000)
                        .HasColumnType("nvarchar(1000)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<bool>("IsTimeExercise")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("Modified")
                        .HasColumnType("datetime2");

                    b.Property<string>("ModifiedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<int?>("NumberOfRepetitions")
                        .HasColumnType("int");

                    b.Property<int?>("TimeInSecond")
                        .HasColumnType("int");

                    b.Property<int>("TypeId")
                        .HasColumnType("int");

                    b.Property<decimal?>("WeightInKilograms")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("WorkoutPlanTrainingSeriesId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("TypeId");

                    b.HasIndex("WorkoutPlanTrainingSeriesId");

                    b.ToTable("WorkoutPlanExercises");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Created = new DateTime(2023, 2, 21, 14, 53, 2, 958, DateTimeKind.Local).AddTicks(392),
                            CreatedBy = "Michał",
                            IsDeleted = false,
                            IsTimeExercise = true,
                            Name = "Burpees",
                            TimeInSecond = 60,
                            TypeId = 9,
                            WorkoutPlanTrainingSeriesId = 1
                        },
                        new
                        {
                            Id = 2,
                            Created = new DateTime(2023, 2, 21, 14, 53, 2, 958, DateTimeKind.Local).AddTicks(392),
                            CreatedBy = "Michał",
                            IsDeleted = false,
                            IsTimeExercise = false,
                            Name = "Pompki klasyczne",
                            NumberOfRepetitions = 10,
                            TypeId = 2,
                            WorkoutPlanTrainingSeriesId = 2
                        },
                        new
                        {
                            Id = 3,
                            Created = new DateTime(2023, 2, 21, 14, 53, 2, 958, DateTimeKind.Local).AddTicks(392),
                            CreatedBy = "Michał",
                            IsDeleted = false,
                            IsTimeExercise = false,
                            Name = "Podciąganie nachwytem",
                            NumberOfRepetitions = 8,
                            TypeId = 1,
                            WorkoutPlanTrainingSeriesId = 2
                        },
                        new
                        {
                            Id = 4,
                            Created = new DateTime(2023, 2, 21, 14, 53, 2, 958, DateTimeKind.Local).AddTicks(392),
                            CreatedBy = "Michał",
                            IsDeleted = false,
                            IsTimeExercise = false,
                            Name = "Martwy ciąg",
                            NumberOfRepetitions = 10,
                            TypeId = 8,
                            WeightInKilograms = 70m,
                            WorkoutPlanTrainingSeriesId = 3
                        });
                });

            modelBuilder.Entity("MyWorkout.Domain.Entities.WorkoutPlanTrainingSeries", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime2");

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("Deleted")
                        .HasColumnType("datetime2");

                    b.Property<string>("DeletedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("Modified")
                        .HasColumnType("datetime2");

                    b.Property<string>("ModifiedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<int>("RestTimeBetweenExercisesInSecond")
                        .HasColumnType("int");

                    b.Property<int>("RestTimeBetweenSeriesInSecond")
                        .HasColumnType("int");

                    b.Property<int>("WorkoutPlanId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("WorkoutPlanId");

                    b.ToTable("WorkoutPlanTrainingSeries");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Created = new DateTime(2023, 2, 21, 14, 53, 2, 958, DateTimeKind.Local).AddTicks(392),
                            CreatedBy = "Michał",
                            IsDeleted = false,
                            Name = "Rozgrzewka",
                            RestTimeBetweenExercisesInSecond = 0,
                            RestTimeBetweenSeriesInSecond = 30,
                            WorkoutPlanId = 1
                        },
                        new
                        {
                            Id = 2,
                            Created = new DateTime(2023, 2, 21, 14, 53, 2, 958, DateTimeKind.Local).AddTicks(392),
                            CreatedBy = "Michał",
                            IsDeleted = false,
                            Name = "Superseria",
                            RestTimeBetweenExercisesInSecond = 0,
                            RestTimeBetweenSeriesInSecond = 180,
                            WorkoutPlanId = 1
                        },
                        new
                        {
                            Id = 3,
                            Created = new DateTime(2023, 2, 21, 14, 53, 2, 958, DateTimeKind.Local).AddTicks(392),
                            CreatedBy = "Michał",
                            IsDeleted = false,
                            Name = "Dobitka",
                            RestTimeBetweenExercisesInSecond = 0,
                            RestTimeBetweenSeriesInSecond = 180,
                            WorkoutPlanId = 1
                        });
                });

            modelBuilder.Entity("MyWorkout.Domain.Entities.WorkoutSchedule", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime2");

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("Deleted")
                        .HasColumnType("datetime2");

                    b.Property<string>("DeletedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool?>("Friday")
                        .HasColumnType("bit");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<bool>("IsPeriod")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("Modified")
                        .HasColumnType("datetime2");

                    b.Property<string>("ModifiedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool?>("Monday")
                        .HasColumnType("bit");

                    b.Property<int?>("PeriodValue")
                        .HasColumnType("int");

                    b.Property<bool?>("Saturday")
                        .HasColumnType("bit");

                    b.Property<bool?>("Sunday")
                        .HasColumnType("bit");

                    b.Property<bool?>("Thursday")
                        .HasColumnType("bit");

                    b.Property<bool?>("Tuesday")
                        .HasColumnType("bit");

                    b.Property<bool?>("Wednesday")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("WorkoutSchedules");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Created = new DateTime(2023, 2, 21, 14, 53, 2, 958, DateTimeKind.Local).AddTicks(392),
                            CreatedBy = "Michał",
                            IsDeleted = false,
                            IsPeriod = true,
                            PeriodValue = 2
                        });
                });

            modelBuilder.Entity("MyWorkout.Domain.Entities.WorkoutTrainingSeries", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime2");

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("Deleted")
                        .HasColumnType("datetime2");

                    b.Property<string>("DeletedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("Modified")
                        .HasColumnType("datetime2");

                    b.Property<string>("ModifiedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<int>("RestTimeBetweenExercisesInSecond")
                        .HasColumnType("int");

                    b.Property<int>("RestTimeBetweenSeriesInSecond")
                        .HasColumnType("int");

                    b.Property<int>("WorkoutId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("WorkoutId");

                    b.ToTable("WorkoutTrainingSeries");
                });

            modelBuilder.Entity("MyWorkout.Domain.Entities.Exercise", b =>
                {
                    b.HasOne("MyWorkout.Domain.Entities.ExerciseType", "Type")
                        .WithMany("Exercises")
                        .HasForeignKey("TypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Type");
                });

            modelBuilder.Entity("MyWorkout.Domain.Entities.WorkoutExercise", b =>
                {
                    b.HasOne("MyWorkout.Domain.Entities.ExerciseType", "Type")
                        .WithMany()
                        .HasForeignKey("TypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MyWorkout.Domain.Entities.WorkoutTrainingSeries", "Series")
                        .WithMany("Exercises")
                        .HasForeignKey("WorkoutTrainingSeriesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Series");

                    b.Navigation("Type");
                });

            modelBuilder.Entity("MyWorkout.Domain.Entities.WorkoutPlan", b =>
                {
                    b.HasOne("MyWorkout.Domain.Entities.WorkoutSchedule", "Schedule")
                        .WithMany()
                        .HasForeignKey("ScheduleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Schedule");
                });

            modelBuilder.Entity("MyWorkout.Domain.Entities.WorkoutPlanExercise", b =>
                {
                    b.HasOne("MyWorkout.Domain.Entities.ExerciseType", "Type")
                        .WithMany()
                        .HasForeignKey("TypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MyWorkout.Domain.Entities.WorkoutPlanTrainingSeries", "Series")
                        .WithMany("Exercises")
                        .HasForeignKey("WorkoutPlanTrainingSeriesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Series");

                    b.Navigation("Type");
                });

            modelBuilder.Entity("MyWorkout.Domain.Entities.WorkoutPlanTrainingSeries", b =>
                {
                    b.HasOne("MyWorkout.Domain.Entities.WorkoutPlan", null)
                        .WithMany("Series")
                        .HasForeignKey("WorkoutPlanId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("MyWorkout.Domain.Entities.WorkoutTrainingSeries", b =>
                {
                    b.HasOne("MyWorkout.Domain.Entities.Workout", null)
                        .WithMany("Series")
                        .HasForeignKey("WorkoutId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("MyWorkout.Domain.Entities.ExerciseType", b =>
                {
                    b.Navigation("Exercises");
                });

            modelBuilder.Entity("MyWorkout.Domain.Entities.Workout", b =>
                {
                    b.Navigation("Series");
                });

            modelBuilder.Entity("MyWorkout.Domain.Entities.WorkoutPlan", b =>
                {
                    b.Navigation("Series");
                });

            modelBuilder.Entity("MyWorkout.Domain.Entities.WorkoutPlanTrainingSeries", b =>
                {
                    b.Navigation("Exercises");
                });

            modelBuilder.Entity("MyWorkout.Domain.Entities.WorkoutTrainingSeries", b =>
                {
                    b.Navigation("Exercises");
                });
#pragma warning restore 612, 618
        }
    }
}

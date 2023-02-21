using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MyWorkout.Persistance.Migrations
{
    /// <inheritdoc />
    public partial class init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ExerciseTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Modified = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Deleted = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExerciseTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Workouts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    WorkoutPlanId = table.Column<int>(type: "int", nullable: true),
                    WorkoutPlanName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    WorkoutDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Note = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Modified = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Deleted = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Workouts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "WorkoutSchedules",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IsPeriod = table.Column<bool>(type: "bit", nullable: false),
                    PeriodValue = table.Column<int>(type: "int", nullable: true),
                    Monday = table.Column<bool>(type: "bit", nullable: true),
                    Tuesday = table.Column<bool>(type: "bit", nullable: true),
                    Wednesday = table.Column<bool>(type: "bit", nullable: true),
                    Thursday = table.Column<bool>(type: "bit", nullable: true),
                    Friday = table.Column<bool>(type: "bit", nullable: true),
                    Saturday = table.Column<bool>(type: "bit", nullable: true),
                    Sunday = table.Column<bool>(type: "bit", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Modified = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Deleted = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WorkoutSchedules", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Exercises",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true),
                    TypeId = table.Column<int>(type: "int", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Modified = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Deleted = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Exercises", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Exercises_ExerciseTypes_TypeId",
                        column: x => x.TypeId,
                        principalTable: "ExerciseTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "WorkoutTrainingSeries",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    RestTimeBetweenExercisesInSecond = table.Column<int>(type: "int", nullable: false),
                    RestTimeBetweenSeriesInSecond = table.Column<int>(type: "int", nullable: false),
                    WorkoutId = table.Column<int>(type: "int", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Modified = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Deleted = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WorkoutTrainingSeries", x => x.Id);
                    table.ForeignKey(
                        name: "FK_WorkoutTrainingSeries_Workouts_WorkoutId",
                        column: x => x.WorkoutId,
                        principalTable: "Workouts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "WorkoutPlans",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true),
                    ScheduleId = table.Column<int>(type: "int", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Modified = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Deleted = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WorkoutPlans", x => x.Id);
                    table.ForeignKey(
                        name: "FK_WorkoutPlans_WorkoutSchedules_ScheduleId",
                        column: x => x.ScheduleId,
                        principalTable: "WorkoutSchedules",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "WorkoutExercises",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true),
                    TypeId = table.Column<int>(type: "int", nullable: false),
                    WorkoutTrainingSeriesId = table.Column<int>(type: "int", nullable: false),
                    IsTimeExercise = table.Column<bool>(type: "bit", nullable: false),
                    NumberOfRepetitions = table.Column<int>(type: "int", nullable: true),
                    NumberOfRepetitionsDone = table.Column<int>(type: "int", nullable: true),
                    TimeInSecond = table.Column<int>(type: "int", nullable: true),
                    TimeInSecondDone = table.Column<int>(type: "int", nullable: true),
                    WeightInKilograms = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Modified = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Deleted = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WorkoutExercises", x => x.Id);
                    table.ForeignKey(
                        name: "FK_WorkoutExercises_ExerciseTypes_TypeId",
                        column: x => x.TypeId,
                        principalTable: "ExerciseTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_WorkoutExercises_WorkoutTrainingSeries_WorkoutTrainingSeriesId",
                        column: x => x.WorkoutTrainingSeriesId,
                        principalTable: "WorkoutTrainingSeries",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "WorkoutPlanTrainingSeries",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    RestTimeBetweenExercisesInSecond = table.Column<int>(type: "int", nullable: false),
                    RestTimeBetweenSeriesInSecond = table.Column<int>(type: "int", nullable: false),
                    WorkoutPlanId = table.Column<int>(type: "int", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Modified = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Deleted = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WorkoutPlanTrainingSeries", x => x.Id);
                    table.ForeignKey(
                        name: "FK_WorkoutPlanTrainingSeries_WorkoutPlans_WorkoutPlanId",
                        column: x => x.WorkoutPlanId,
                        principalTable: "WorkoutPlans",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "WorkoutPlanExercises",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true),
                    TypeId = table.Column<int>(type: "int", nullable: false),
                    WorkoutPlanTrainingSeriesId = table.Column<int>(type: "int", nullable: false),
                    IsTimeExercise = table.Column<bool>(type: "bit", nullable: false),
                    NumberOfRepetitions = table.Column<int>(type: "int", nullable: true),
                    TimeInSecond = table.Column<int>(type: "int", nullable: true),
                    WeightInKilograms = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Modified = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Deleted = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WorkoutPlanExercises", x => x.Id);
                    table.ForeignKey(
                        name: "FK_WorkoutPlanExercises_ExerciseTypes_TypeId",
                        column: x => x.TypeId,
                        principalTable: "ExerciseTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_WorkoutPlanExercises_WorkoutPlanTrainingSeries_WorkoutPlanTrainingSeriesId",
                        column: x => x.WorkoutPlanTrainingSeriesId,
                        principalTable: "WorkoutPlanTrainingSeries",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "ExerciseTypes",
                columns: new[] { "Id", "Created", "CreatedBy", "Deleted", "DeletedBy", "IsDeleted", "Modified", "ModifiedBy", "Name" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 2, 21, 14, 53, 2, 958, DateTimeKind.Local).AddTicks(392), "Michał", null, null, false, null, null, "Ćwiczenia na plecy" },
                    { 2, new DateTime(2023, 2, 21, 14, 53, 2, 958, DateTimeKind.Local).AddTicks(392), "Michał", null, null, false, null, null, "Ćwiczenia na klatkę" },
                    { 3, new DateTime(2023, 2, 21, 14, 53, 2, 958, DateTimeKind.Local).AddTicks(392), "Michał", null, null, false, null, null, "Ćwiczenia na nogi" },
                    { 4, new DateTime(2023, 2, 21, 14, 53, 2, 958, DateTimeKind.Local).AddTicks(392), "Michał", null, null, false, null, null, "Ćwiczenia na barki" },
                    { 5, new DateTime(2023, 2, 21, 14, 53, 2, 958, DateTimeKind.Local).AddTicks(392), "Michał", null, null, false, null, null, "Ćwiczenia na biceps" },
                    { 6, new DateTime(2023, 2, 21, 14, 53, 2, 958, DateTimeKind.Local).AddTicks(392), "Michał", null, null, false, null, null, "Ćwiczenia na triceps" },
                    { 7, new DateTime(2023, 2, 21, 14, 53, 2, 958, DateTimeKind.Local).AddTicks(392), "Michał", null, null, false, null, null, "Ćwiczenia na core" },
                    { 8, new DateTime(2023, 2, 21, 14, 53, 2, 958, DateTimeKind.Local).AddTicks(392), "Michał", null, null, false, null, null, "Ćwiczenia na całe ciało/wielostawowe" },
                    { 9, new DateTime(2023, 2, 21, 14, 53, 2, 958, DateTimeKind.Local).AddTicks(392), "Michał", null, null, false, null, null, "Ćwiczenia kardio" }
                });

            migrationBuilder.InsertData(
                table: "WorkoutSchedules",
                columns: new[] { "Id", "Created", "CreatedBy", "Deleted", "DeletedBy", "Friday", "IsDeleted", "IsPeriod", "Modified", "ModifiedBy", "Monday", "PeriodValue", "Saturday", "Sunday", "Thursday", "Tuesday", "Wednesday" },
                values: new object[] { 1, new DateTime(2023, 2, 21, 14, 53, 2, 958, DateTimeKind.Local).AddTicks(392), "Michał", null, null, null, false, true, null, null, null, 2, null, null, null, null, null });

            migrationBuilder.InsertData(
                table: "Exercises",
                columns: new[] { "Id", "Created", "CreatedBy", "Deleted", "DeletedBy", "Description", "IsDeleted", "Modified", "ModifiedBy", "Name", "TypeId" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 2, 21, 14, 53, 2, 958, DateTimeKind.Local).AddTicks(392), "Michał", null, null, null, false, null, null, "Pompki klasyczne", 2 },
                    { 2, new DateTime(2023, 2, 21, 14, 53, 2, 958, DateTimeKind.Local).AddTicks(392), "Michał", null, null, null, false, null, null, "Pompki na barki", 2 },
                    { 3, new DateTime(2023, 2, 21, 14, 53, 2, 958, DateTimeKind.Local).AddTicks(392), "Michał", null, null, null, false, null, null, "Pompki wąskie", 2 },
                    { 4, new DateTime(2023, 2, 21, 14, 53, 2, 958, DateTimeKind.Local).AddTicks(392), "Michał", null, null, null, false, null, null, "Podciąganie nachwytem", 1 },
                    { 5, new DateTime(2023, 2, 21, 14, 53, 2, 958, DateTimeKind.Local).AddTicks(392), "Michał", null, null, null, false, null, null, "Podciąganie podchwytem", 1 },
                    { 6, new DateTime(2023, 2, 21, 14, 53, 2, 958, DateTimeKind.Local).AddTicks(392), "Michał", null, null, null, false, null, null, "Podciąganie australijskie", 1 },
                    { 7, new DateTime(2023, 2, 21, 14, 53, 2, 958, DateTimeKind.Local).AddTicks(392), "Michał", null, null, null, false, null, null, "Przysiady klasyczne", 3 },
                    { 8, new DateTime(2023, 2, 21, 14, 53, 2, 958, DateTimeKind.Local).AddTicks(392), "Michał", null, null, null, false, null, null, "Przysiady na jednej nodze", 3 },
                    { 9, new DateTime(2023, 2, 21, 14, 53, 2, 958, DateTimeKind.Local).AddTicks(392), "Michał", null, null, null, false, null, null, "Przysiady bułgarskie", 3 },
                    { 10, new DateTime(2023, 2, 21, 14, 53, 2, 958, DateTimeKind.Local).AddTicks(392), "Michał", null, null, null, false, null, null, "Martwy ciąg", 8 },
                    { 11, new DateTime(2023, 2, 21, 14, 53, 2, 958, DateTimeKind.Local).AddTicks(392), "Michał", null, null, null, false, null, null, "Deska na przedramionach", 7 },
                    { 12, new DateTime(2023, 2, 21, 14, 53, 2, 958, DateTimeKind.Local).AddTicks(392), "Michał", null, null, null, false, null, null, "Burpees", 9 }
                });

            migrationBuilder.InsertData(
                table: "WorkoutPlans",
                columns: new[] { "Id", "Created", "CreatedBy", "Deleted", "DeletedBy", "Description", "IsDeleted", "Modified", "ModifiedBy", "Name", "ScheduleId" },
                values: new object[] { 1, new DateTime(2023, 2, 21, 14, 53, 2, 958, DateTimeKind.Local).AddTicks(392), "Michał", null, null, "Mój pierwszy plan treningoey oparty na ćwiczeniach wielostawowych", false, null, null, "Mój plan", 1 });

            migrationBuilder.InsertData(
                table: "WorkoutPlanTrainingSeries",
                columns: new[] { "Id", "Created", "CreatedBy", "Deleted", "DeletedBy", "IsDeleted", "Modified", "ModifiedBy", "Name", "RestTimeBetweenExercisesInSecond", "RestTimeBetweenSeriesInSecond", "WorkoutPlanId" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 2, 21, 14, 53, 2, 958, DateTimeKind.Local).AddTicks(392), "Michał", null, null, false, null, null, "Rozgrzewka", 0, 30, 1 },
                    { 2, new DateTime(2023, 2, 21, 14, 53, 2, 958, DateTimeKind.Local).AddTicks(392), "Michał", null, null, false, null, null, "Superseria", 0, 180, 1 },
                    { 3, new DateTime(2023, 2, 21, 14, 53, 2, 958, DateTimeKind.Local).AddTicks(392), "Michał", null, null, false, null, null, "Dobitka", 0, 180, 1 }
                });

            migrationBuilder.InsertData(
                table: "WorkoutPlanExercises",
                columns: new[] { "Id", "Created", "CreatedBy", "Deleted", "DeletedBy", "Description", "IsDeleted", "IsTimeExercise", "Modified", "ModifiedBy", "Name", "NumberOfRepetitions", "TimeInSecond", "TypeId", "WeightInKilograms", "WorkoutPlanTrainingSeriesId" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 2, 21, 14, 53, 2, 958, DateTimeKind.Local).AddTicks(392), "Michał", null, null, null, false, true, null, null, "Burpees", null, 60, 9, null, 1 },
                    { 2, new DateTime(2023, 2, 21, 14, 53, 2, 958, DateTimeKind.Local).AddTicks(392), "Michał", null, null, null, false, false, null, null, "Pompki klasyczne", 10, null, 2, null, 2 },
                    { 3, new DateTime(2023, 2, 21, 14, 53, 2, 958, DateTimeKind.Local).AddTicks(392), "Michał", null, null, null, false, false, null, null, "Podciąganie nachwytem", 8, null, 1, null, 2 },
                    { 4, new DateTime(2023, 2, 21, 14, 53, 2, 958, DateTimeKind.Local).AddTicks(392), "Michał", null, null, null, false, false, null, null, "Martwy ciąg", 10, null, 8, 70m, 3 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Exercises_TypeId",
                table: "Exercises",
                column: "TypeId");

            migrationBuilder.CreateIndex(
                name: "IX_WorkoutExercises_TypeId",
                table: "WorkoutExercises",
                column: "TypeId");

            migrationBuilder.CreateIndex(
                name: "IX_WorkoutExercises_WorkoutTrainingSeriesId",
                table: "WorkoutExercises",
                column: "WorkoutTrainingSeriesId");

            migrationBuilder.CreateIndex(
                name: "IX_WorkoutPlanExercises_TypeId",
                table: "WorkoutPlanExercises",
                column: "TypeId");

            migrationBuilder.CreateIndex(
                name: "IX_WorkoutPlanExercises_WorkoutPlanTrainingSeriesId",
                table: "WorkoutPlanExercises",
                column: "WorkoutPlanTrainingSeriesId");

            migrationBuilder.CreateIndex(
                name: "IX_WorkoutPlans_ScheduleId",
                table: "WorkoutPlans",
                column: "ScheduleId");

            migrationBuilder.CreateIndex(
                name: "IX_WorkoutPlanTrainingSeries_WorkoutPlanId",
                table: "WorkoutPlanTrainingSeries",
                column: "WorkoutPlanId");

            migrationBuilder.CreateIndex(
                name: "IX_WorkoutTrainingSeries_WorkoutId",
                table: "WorkoutTrainingSeries",
                column: "WorkoutId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Exercises");

            migrationBuilder.DropTable(
                name: "WorkoutExercises");

            migrationBuilder.DropTable(
                name: "WorkoutPlanExercises");

            migrationBuilder.DropTable(
                name: "WorkoutTrainingSeries");

            migrationBuilder.DropTable(
                name: "ExerciseTypes");

            migrationBuilder.DropTable(
                name: "WorkoutPlanTrainingSeries");

            migrationBuilder.DropTable(
                name: "Workouts");

            migrationBuilder.DropTable(
                name: "WorkoutPlans");

            migrationBuilder.DropTable(
                name: "WorkoutSchedules");
        }
    }
}

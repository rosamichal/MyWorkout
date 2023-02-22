using FluentValidation;

namespace MyWorkout.Application.Features.WorkoutPlans.Commands.CreateWorkoutPlan
{
    public class CreateWorkoutPlanValidator : AbstractValidator<CreateWorkoutPlanCommand>
    {
        public CreateWorkoutPlanValidator()
        {
            RuleFor(o => o.Name).NotEmpty().MaximumLength(200);
            RuleFor(o => o.Description).MaximumLength(1000);
            When(o => o.Schedule.IsPeriod, () =>
            {
                RuleFor(o => o.Schedule.RestDays).NotNull().GreaterThanOrEqualTo(0);
            });
        }
    }
}

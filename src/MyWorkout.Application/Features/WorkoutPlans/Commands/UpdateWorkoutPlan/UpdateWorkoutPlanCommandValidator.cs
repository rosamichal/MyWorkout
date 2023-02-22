using FluentValidation;

namespace MyWorkout.Application.Features.WorkoutPlans.Commands.UpdateWorkoutPlan
{
    public class UpdateWorkoutPlanCommandValidator : AbstractValidator<UpdateWorkoutPlanCommand>
    {
        public UpdateWorkoutPlanCommandValidator()
        {
            RuleFor(o => o.WorkoutPlanId).GreaterThan(0);
            RuleFor(o => o.Name).NotEmpty().MaximumLength(200);
            RuleFor(o => o.Description).NotEmpty().MaximumLength(1000);
        }
    }
}

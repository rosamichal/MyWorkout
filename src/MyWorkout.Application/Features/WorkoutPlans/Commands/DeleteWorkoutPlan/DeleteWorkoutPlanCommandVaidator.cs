using FluentValidation;

namespace MyWorkout.Application.Features.WorkoutPlans.Commands.DeleteWorkoutPlan
{
    public class DeleteWorkoutPlanCommandVaidator : AbstractValidator<DeleteWorkoutPlanCommand>
    {
        public DeleteWorkoutPlanCommandVaidator()
        {
            RuleFor(o => o.WorkoutPlanId).GreaterThan(0);
        }
    }
}

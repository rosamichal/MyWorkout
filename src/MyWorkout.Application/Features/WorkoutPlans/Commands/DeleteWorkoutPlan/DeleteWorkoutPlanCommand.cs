using MediatR;
using Microsoft.EntityFrameworkCore;
using MyWorkout.Application.Common.Interfaces;

namespace MyWorkout.Application.Features.WorkoutPlans.Commands.DeleteWorkoutPlan
{
    public class DeleteWorkoutPlanCommand : IRequest
    {
        public int WorkoutPlanId { get; set; }
    }

    public class DeleteWorkoutPlanCommandHandler : IRequestHandler<DeleteWorkoutPlanCommand>
    {
        private readonly IMyWorkoutDbContext _dbContext;

        public DeleteWorkoutPlanCommandHandler(IMyWorkoutDbContext dbContext)
        {
            this._dbContext = dbContext;
        }

        public async Task Handle(DeleteWorkoutPlanCommand request, CancellationToken cancellationToken)
        {
            var workoutPlanToDelete = await _dbContext.WorkoutPlans.FirstOrDefaultAsync(t => t.Id == request.WorkoutPlanId);

            if (workoutPlanToDelete != null)
            {
                _dbContext.WorkoutPlans.Remove(workoutPlanToDelete);

                await _dbContext.SaveChangesAsync(cancellationToken);
            }
        }
    }
}

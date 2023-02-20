using MediatR;
using Microsoft.EntityFrameworkCore;
using MyWorkout.Application.Common.Interfaces;

namespace MyWorkout.Application.Features.WorkoutPlans.Commands.UpdateWorkoutPlan
{
    public class UpdateWorkoutPlanCommand : IRequest
    {
        public int WorkoutPlnId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }

    public class UpdateWorkoutPlanCommandHandler : IRequestHandler<UpdateWorkoutPlanCommand>
    {
        private readonly IMyWorkoutDbContext _dbContext;

        public UpdateWorkoutPlanCommandHandler(IMyWorkoutDbContext dbContext)
        {
            this._dbContext = dbContext;
        }

        public async Task Handle(UpdateWorkoutPlanCommand request, CancellationToken cancellationToken)
        {
            var workoutPlan = await _dbContext.WorkoutPlans.FirstOrDefaultAsync(o => o.Id == request.WorkoutPlnId);

            if (workoutPlan is not null)
            {
                workoutPlan.Name = request.Name;
                workoutPlan.Description = request.Description;

                await _dbContext.SaveChangesAsync(cancellationToken);
            }
            
        }
    }
}

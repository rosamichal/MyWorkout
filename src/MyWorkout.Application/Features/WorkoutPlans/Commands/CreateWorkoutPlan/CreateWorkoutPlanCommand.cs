using MediatR;
using MyWorkout.Application.Common.Interfaces;
using MyWorkout.Application.Common.Wrappers;
using MyWorkout.Domain.Entities;

namespace MyWorkout.Application.Features.WorkoutPlans.Commands.CreateWorkoutPlan
{
    public class CreateWorkoutPlanCommand : IRequest<ApiResponse<int>>
    {
        public string Name { get; set; }
        public string Description { get; set; }

    }

    public class CreateWorkoutPlanCommandHandler : IRequestHandler<CreateWorkoutPlanCommand, ApiResponse<int>>
    {
        private readonly IMyWorkoutDbContext _dbContext;

        public CreateWorkoutPlanCommandHandler(IMyWorkoutDbContext dbContext)
        {
            this._dbContext = dbContext;
        }

        public async Task<ApiResponse<int>> Handle(CreateWorkoutPlanCommand request, CancellationToken cancellationToken)
        {
            var workoutPlan = new WorkoutPlan
            {
                Name = request.Name,
                Description = request.Description
            };

            _dbContext.WorkoutPlans.Add(workoutPlan);

            await _dbContext.SaveChangesAsync(cancellationToken);

            return ApiResponse<int>.Success(workoutPlan.Id);
        }
    }
}

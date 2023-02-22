using AutoMapper;

using MediatR;
using MyWorkout.Application.Common.Interfaces;
using MyWorkout.Application.Common.Wrappers;
using MyWorkout.Application.Features.WorkoutPlans.Queries.GetWorkoutPlanDetail.Dtos;
using MyWorkout.Domain.Entities;

namespace MyWorkout.Application.Features.WorkoutPlans.Commands.CreateWorkoutPlan
{
    public class CreateWorkoutPlanCommand : IRequest<ApiResponse<int>>
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public WorkoutScheduleDto Schedule { get; set; }
    }

    public class CreateWorkoutPlanCommandHandler : IRequestHandler<CreateWorkoutPlanCommand, ApiResponse<int>>
    {
        private readonly IMyWorkoutDbContext _dbContext;
        private readonly IMapper _mapper;

        public CreateWorkoutPlanCommandHandler(IMyWorkoutDbContext dbContext, IMapper mapper)
        {
            this._dbContext = dbContext;
            this._mapper = mapper;
        }

        public async Task<ApiResponse<int>> Handle(CreateWorkoutPlanCommand request, CancellationToken cancellationToken)
        {
            var schedule = _mapper.Map<WorkoutSchedule>(request.Schedule);

            var workoutPlan = new WorkoutPlan
            {
                Name = request.Name,
                Description = request.Description,
                Schedule = schedule
            };

            _dbContext.WorkoutPlans.Add(workoutPlan);

            await _dbContext.SaveChangesAsync(cancellationToken);

            return ApiResponse<int>.Success(workoutPlan.Id);
        }
    }
}

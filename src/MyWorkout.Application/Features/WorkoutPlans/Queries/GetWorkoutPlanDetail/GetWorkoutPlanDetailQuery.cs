using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using MyWorkout.Application.Common.Interfaces;

namespace MyWorkout.Application.Features.WorkoutPlans.Queries.GetWorkoutPlanDetail
{
    public class GetWorkoutPlanDetailQuery : IRequest<WorkoutPlanDetailViewModel>
    {
        public GetWorkoutPlanDetailQuery(int workoutPlanId)
        {
            WorkoutPlanId = workoutPlanId;
        }

        public int WorkoutPlanId { get; }
    }

    public class GetWorkoutPlanDetailQueryHandler : IRequestHandler<GetWorkoutPlanDetailQuery, WorkoutPlanDetailViewModel>
    {
        private readonly IMyWorkoutDbContext _dbContext;
        private readonly IMapper _mapper;

        public GetWorkoutPlanDetailQueryHandler(IMyWorkoutDbContext dbContext, IMapper mapper)
        {
            this._dbContext = dbContext;
            this._mapper = mapper;
        }
        public async Task<WorkoutPlanDetailViewModel> Handle(GetWorkoutPlanDetailQuery request, CancellationToken cancellationToken)
        {
            var workoutPlans = await _dbContext.WorkoutPlans
                .Include(o => o.Schedule)
                .Include(o => o.Series)
                .ThenInclude(o => o.Exercises)
                .ThenInclude(o => o.Type)
                .Where(o => !o.IsDeleted && o.Id == request.WorkoutPlanId)
                .FirstOrDefaultAsync();

            return _mapper.Map<WorkoutPlanDetailViewModel>(workoutPlans);
        }
    }
}

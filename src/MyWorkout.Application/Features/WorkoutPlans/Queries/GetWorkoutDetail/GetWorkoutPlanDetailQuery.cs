using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using MyWorkout.Application.Common.Interfaces;

namespace MyWorkout.Application.Features.WorkoutPlans.Queries.GetWorkoutDetail
{
    public class GetWorkoutPlanDetailQuery : IRequest<WorkoutPlanDetailViewModel>
    {
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
                .Where(o => !o.IsDeleted && o.Id == request.WorkoutPlanId)
                .FirstOrDefaultAsync();

            return _mapper.Map<WorkoutPlanDetailViewModel>(workoutPlans);
        }
    }
}

using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using MyWorkout.Application.Common.Interfaces;

namespace MyWorkout.Application.Features.WorkoutPlans.Queries.GetAllWorkoutPlans
{
    public class GetAllWorkoutPlansQuery : IRequest<List<WorkoutPlanListItemViewModel>>
    {
    }

    public class GetAllWorkoutPlansQueryHandler : IRequestHandler<GetAllWorkoutPlansQuery, List<WorkoutPlanListItemViewModel>>
    {
        private readonly IMyWorkoutDbContext _dbContext;
        private readonly IMapper _mapper;

        public GetAllWorkoutPlansQueryHandler(IMyWorkoutDbContext dbContext, IMapper mapper)
        {
            this._dbContext = dbContext;
            this._mapper = mapper;
        }
        public async Task<List<WorkoutPlanListItemViewModel>> Handle(GetAllWorkoutPlansQuery request, CancellationToken cancellationToken)
        {
            var workoutPlans = await _dbContext.WorkoutPlans
                .Where(o => !o.IsDeleted)
                .ToListAsync();

            return _mapper.Map<List<WorkoutPlanListItemViewModel>>(workoutPlans);
        }
    }
}

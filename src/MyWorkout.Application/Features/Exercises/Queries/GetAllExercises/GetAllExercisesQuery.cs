using AutoMapper;
using MediatR;

using Microsoft.EntityFrameworkCore;

using MyWorkout.Application.Common.Interfaces;
using MyWorkout.Domain.Entities;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyWorkout.Application.Features.Exercises.Queries.GetAllExercises
{
    public class GetAllExercisesQuery : IRequest<List<ExerciseListItemViewModel>>
    {
    }

    public class GetAllExercisesQueryHandler : IRequestHandler<GetAllExercisesQuery, List<ExerciseListItemViewModel>>
    {
        private readonly IMyWorkoutDbContext _dbContext;
        private readonly IMapper _mapper;

        public GetAllExercisesQueryHandler(IMyWorkoutDbContext dbContext, IMapper mapper)
        {
            this._dbContext = dbContext;
            this._mapper = mapper;
        }
        public async Task<List<ExerciseListItemViewModel>> Handle(GetAllExercisesQuery request, CancellationToken cancellationToken)
        {
            var exercises = await _dbContext.Exercises
                .Where(e => !e.IsDeleted)
                .ToListAsync();

            return _mapper.Map<List<ExerciseListItemViewModel>>(exercises);
        }
    }
}

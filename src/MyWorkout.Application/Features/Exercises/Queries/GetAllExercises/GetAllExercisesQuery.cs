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

        public GetAllExercisesQueryHandler(IMyWorkoutDbContext dbContext)
        {
            this._dbContext = dbContext;
        }
        public async Task<List<ExerciseListItemViewModel>> Handle(GetAllExercisesQuery request, CancellationToken cancellationToken)
        {
            return await _dbContext.Exercises
                .Where(e => !e.IsDeleted)
                .Select(e => new ExerciseListItemViewModel { ExerciseId = e.Id, Name = e.Name})
                .ToListAsync();
        }
    }
}

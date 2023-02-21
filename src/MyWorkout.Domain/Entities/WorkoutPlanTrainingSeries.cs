using MyWorkout.Domain.Common;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyWorkout.Domain.Entities
{
    public class WorkoutPlanTrainingSeries : AuditableEntity
    {
        public string Name { get; set; }
        public int RestTimeBetweenExercisesInSecond { get; set; }
        public int RestTimeBetweenSeriesInSecond { get; set; }
        public List<WorkoutPlanExercise> MyProperty { get; set; }
    }
}

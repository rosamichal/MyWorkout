using MyWorkout.Application.Common.Interfaces;

namespace MyWorkout.Infrastructure.Services
{
    internal class DateTimeService : IDateTime
    {
        public DateTime Now => DateTime.Now;
    }
}

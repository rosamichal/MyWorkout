using Microsoft.EntityFrameworkCore;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyWorkout.Persistance
{
    internal class MyWorkoutDbContext : DbContext
    {
        public MyWorkoutDbContext(DbContextOptions<MyWorkoutDbContext> options) : base(options)
        {

        }
    }
}

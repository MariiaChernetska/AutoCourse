using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutoCourse.Models
{
    public class CarContext:DbContext
    {
        public DbSet<CarCharacterisctics> CarCharacteristics { get; set; }
        public CarContext(DbContextOptions<CarContext> options)
            : base(options)
        {
        }
    }
}

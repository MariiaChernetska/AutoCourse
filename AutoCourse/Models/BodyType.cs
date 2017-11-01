using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutoCourse.Models
{
    public class BodyType
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public VehicleType VehicleType { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutoCourse.Models
{
    public class Car
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public BodyType BodyType { get; set; }
        public Model Model { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutoCourse.Models
{
    public class CarCharacterisctics
    {
        public int ID { get; set; }
        public Car Car { get; set; }
        public TechnicalCharacteristics TechnicalCharacteristics { get; set; }
        public string Value { get; set; }
    }
}

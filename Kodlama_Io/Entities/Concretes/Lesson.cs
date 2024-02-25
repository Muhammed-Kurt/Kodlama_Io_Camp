using Core.DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concretes
{
    public class Lesson : Entity
    {
        public string Name { get; set; }
        public int CoursePathId { get; set; }
        public CoursePath CoursePath { get; set; }
    }
}

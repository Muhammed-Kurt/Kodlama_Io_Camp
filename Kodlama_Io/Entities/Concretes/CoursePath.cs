using Core.DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concretes;

public class CoursePath : Entity
{
    public string Name { get; set; }
    public DateTime CourseStartTime { get; set; }

    public List<Course> Courses { get; set; }
    public List<Lesson> Lessons { get; set; }


    public CoursePath()
    {

    }

    public CoursePath(int id, string name, DateTime courseStartTime) : this()
    {
        Id = id;
        Name = name;
        CourseStartTime = courseStartTime;
    }
}

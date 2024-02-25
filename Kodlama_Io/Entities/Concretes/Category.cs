using Core.DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concretes;

public class Category : Entity
{
    public string Name { get; set; }
    public List<Course> Courses { get; set; }

    public Category()
    {

    }

    public Category(int id, string name) : this()
    {
        Id = id;
        Name = name;
    }
}

using Core.DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concretes;

public class Course : Entity
{
    public string Name { get; set; }
    public string Description { get; set; }
    public DateTime StartDate { get; set; }
    public string ImageUrl { get; set; }
    public double Price { get; set; }

    public Instructor Instructor { get; set; }
    public List<Category> Categories { get; set; }
}

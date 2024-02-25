using Core.DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concretes
{
    public class Instructor : Entity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string ImageUrl { get; set; }
        public string Description { get; set; }
        public List<Course> Courses { get; set; }

        public Instructor()
        {

        }
        public Instructor(int id, string firstName, string lastName, string imageUrl, string description) : this()
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            ImageUrl = imageUrl;
            Description = description;
        }
    }
}

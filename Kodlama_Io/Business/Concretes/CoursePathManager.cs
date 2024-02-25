using DataAccess.Abstracts;
using Entities.Concretes;

namespace Business.Concretes
{
    public class CoursePathManager
    {
        ICoursePathDal _coursePathDal;
        public CoursePathManager(ICoursePathDal coursePathDal)
        {
            _coursePathDal = coursePathDal;
        }

        public void Add(CoursePath coursePath)
        {
            _coursePathDal.Add(coursePath);
        }

        public void Delete(CoursePath coursePath)
        {
            _coursePathDal.Delete(coursePath);
        }

        public CoursePath Get(int id)
        {
            return _coursePathDal.Get(x => x.Id == id);
        }

        public List<CoursePath> GetAll()
        {
            return _coursePathDal.GetList().ToList();
        }

        public void Update(CoursePath coursePath)
        {
            _coursePathDal.Update(coursePath);
        }
    }
}

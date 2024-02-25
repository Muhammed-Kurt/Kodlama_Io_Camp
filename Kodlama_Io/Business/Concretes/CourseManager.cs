using Business.Abstracts;
using DataAccess.Abstracts;
using Entities.Concretes;

public class CourseManager : ICourseService
{
    ICourseDal _courseDal;
    public CourseManager(ICourseDal courseDal)
    {
        _courseDal = courseDal;
    }

    public void Add(Course course)
    {
        _courseDal.Add(course);
    }

    public void Delete(Course course)
    {
        _courseDal.Delete(course);
    }

    public Course Get(int id)
    {
        return _courseDal.Get(x => x.Id == id);
    }

    public List<Course> GetAll()
    {
        return _courseDal.GetList().ToList();
    }

    public void Update(Course course)
    {
        _courseDal.Update(course);
    }
}
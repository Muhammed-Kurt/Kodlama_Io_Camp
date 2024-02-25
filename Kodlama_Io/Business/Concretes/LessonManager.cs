using Business.Abstracts;
using DataAccess.Abstracts;
using Entities.Concretes;

namespace Business.Concretes;

public class LessonManager : ILessonService
{
    ILessonDal _lessonDal;
    public LessonManager(ILessonDal lessonDal)
    {
        _lessonDal = lessonDal;
    }

    public void Add(Lesson lesson)
    {
        _lessonDal.Add(lesson);
    }

    public void Delete(Lesson lesson)
    {
        _lessonDal.Delete(lesson);
    }

    public Lesson Get(int id)
    {
        return _lessonDal.Get(x => x.Id == id);
    }

    public List<Lesson> GetAll()
    {
        return _lessonDal.GetList().ToList();
    }

    public void Update(Lesson lesson)
    {
        _lessonDal.Update(lesson);
    }
}
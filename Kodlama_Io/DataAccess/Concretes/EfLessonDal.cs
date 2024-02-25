using Core.DataAccess.EntityFramework;
using Entities.Concretes;

namespace DataAccess.Concretes;

public class EfLessonDal : EfEntityRepositoryBase<Lesson, KodlamaIoContext>
{
}
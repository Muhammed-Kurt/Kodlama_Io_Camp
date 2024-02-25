
using Core.DataAccess;
using Entities.Concretes;

namespace DataAccess.Abstracts;

public interface ILessonDal : IEntityRepository<Lesson>
{
}
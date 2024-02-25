using Core.DataAccess.EntityFramework;
using Entities.Concretes;

namespace DataAccess.Concretes;

public class EfCourseDal : EfEntityRepositoryBase<Course, KodlamaIoContext>
{
}
using GenericRepositoryEF.Entities.Dtos.StudentModels;
using GenericRepositoryEF.Entities.Entities;
using GenericRepositoryEF.Repository.Abstract;
using GenericRepositoryEF.Repository.Context;
using Microsoft.EntityFrameworkCore;
using System.Xml.Linq;

namespace GenericRepositoryEF.Repository.Concrete
{
    public class StudentRepository : GenericRepository<Student>, IStudentRepository
    {
        AppDbContext _appDbContext;
        public StudentRepository(AppDbContext context) : base(context)
        {
            _appDbContext = context;
        }

        public List<StudentWithGradeModel> GetAllStudentsWithGrade()
        {
            var query = _appDbContext
                 .Students
                 .Include(x => x.Grade)
                 .Select(x => new StudentWithGradeModel
                 {
                     Id = x.Id,
                     StudentName = x.NameSurname,
                     ContactNumber = x.PhoneNumber,
                     GradeName = x.Grade.GradeName
                 });
            return query.ToList();
        }
    }
}

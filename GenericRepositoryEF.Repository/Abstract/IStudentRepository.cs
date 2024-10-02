using GenericRepositoryEF.Entities.Dtos.StudentModels;
using GenericRepositoryEF.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericRepositoryEF.Repository.Abstract
{
    public interface IStudentRepository : IGenericRepository<Student>
    {
        List<StudentWithGradeModel> GetAllStudentsWithGrade();
    }
}

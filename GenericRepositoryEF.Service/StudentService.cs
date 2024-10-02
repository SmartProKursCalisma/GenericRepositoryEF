using GenericRepositoryEF.Entities.Dtos.StudentModels;
using GenericRepositoryEF.Entities.Entities;
using GenericRepositoryEF.Repository.Abstract;
using GenericRepositoryEF.Repository.Concrete;
using GenericRepositoryEF.Repository.Context;

namespace GenericRepositoryEF.Service
{
    public class StudentService
    {
        AppDbContext _context;
        IStudentRepository _studentRepository;
        public StudentService()
        {
            _context = new AppDbContext();
            _studentRepository = new StudentRepository(_context);
        }
        public Student GetStudentById(int id)
        {
            if (id > 0)
            {
                return _studentRepository.GetById(id);

            }
            return null;
        }
        public List<Student> GetAllStudents()
        {
            return _studentRepository.GetAll();
        }
        public List<StudentWithGradeModel> GetAllStudentWithGrades()
        {
            return _studentRepository.GetAllStudentsWithGrade();
        }
        public void AddStudent(Student student)
        {
            if (student != null)
            {
                _studentRepository.Add(student);
            }
        }
        public void UpdateStudent(Student student)
        {
            if (student != null)
            {
                _studentRepository.Update(student);
            }
        }
        public void DeleteStudent(int id)
        {
            if (id > 0)
            {
                _studentRepository.Delete(id);
            }
        }
    }
}

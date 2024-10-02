using GenericRepositoryEF.Entities.Entities;
using GenericRepositoryEF.Repository.Abstract;
using GenericRepositoryEF.Repository.Concrete;
using GenericRepositoryEF.Repository.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericRepositoryEF.Service
{
    public class GradeService
    {
        IGradeRepository _gradeRepository;
        AppDbContext _context;
        public GradeService()
        {
            _context = new AppDbContext();
            _gradeRepository = new GradeRepository(_context);
        }
        public Grade GetGradeById(int id)
        {
           return _gradeRepository.GetById(id);
        }
        public List<Grade> GetGradeList()
        {
            return _gradeRepository.GetAll();
        }
    }
}

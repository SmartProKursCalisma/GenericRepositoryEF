using GenericRepositoryEF.Entities.Entities;
using GenericRepositoryEF.Repository.Abstract;
using GenericRepositoryEF.Repository.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericRepositoryEF.Repository.Concrete
{
    public class GradeRepository : GenericRepository<Grade>, IGradeRepository
    {
        public GradeRepository(AppDbContext context) : base(context)
        {
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericRepositoryEF.Entities.Entities
{
    public class Grade : IBaseEntity
    {
        public int Id { get; set; }
        public string GradeName { get; set; }
    }
}

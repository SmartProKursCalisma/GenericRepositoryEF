using GenericRepositoryEF.Entities.Dtos.UserModels;
using GenericRepositoryEF.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericRepositoryEF.Repository.Abstract
{
    public interface IUserRepository : IGenericRepository<User>
    {
        UserLoginResponseModel Login(UserLoginRequestModel model);

    }
}

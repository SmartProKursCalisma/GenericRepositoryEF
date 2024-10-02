using GenericRepositoryEF.Entities.Dtos.UserModels;
using GenericRepositoryEF.Entities.Entities;
using GenericRepositoryEF.Repository.Abstract;
using GenericRepositoryEF.Repository.Context;

namespace GenericRepositoryEF.Repository.Concrete
{
    public class UserRepository : GenericRepository<User>, IUserRepository
    {
        private readonly AppDbContext _appDbContext;
        public UserRepository(AppDbContext dbContext) : base(dbContext)
        {
            _appDbContext = dbContext;
        }
        public UserLoginResponseModel Login(UserLoginRequestModel model)
        {
            var user = _appDbContext.Users.FirstOrDefault(x => x.Username == model.UserName
             && x.Password == model.Password);
            if (user != null)
            {
                return new UserLoginResponseModel
                {
                    Email = user.Email,
                    Role = user.Role
                };
            }
            return null;
        }
    }
}

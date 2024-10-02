using GenericRepositoryEF.Entities.Dtos.UserModels;
using GenericRepositoryEF.Entities.Entities;
using GenericRepositoryEF.Repository.Concrete;
using GenericRepositoryEF.Repository.Context;

namespace GenericRepositoryEF.Service
{
    public class UserService
    {
        AppDbContext _context;
        UserRepository _userRepository;
        public UserService()
        {
            _context = new AppDbContext();
            _userRepository = new UserRepository(_context);
        }
        public List<User> GetAllUsers()
        {
           var users =  _userRepository.GetAll();
            return users;
        }
        public UserLoginResponseModel? Login(UserLoginRequestModel model)
        {

           var user =  _userRepository.Login(model);
            if (user != null)
            {
                return user;
            }
            return null;
        }
    }
}

using BaseProject.Repositories;
using HukukBuroYonetimSistemi.Models.Domain;

namespace BaseProject.Services
{
    public class UserService
    {
        private readonly UserRepository _UserRepository;

        public UserService(UserRepository UserRepository)
        {
            _UserRepository = UserRepository;
        }
        public List<Users> GetUsers()
        {
            var Users = _UserRepository.GetUsers();
            return Users;
        }
    }
}

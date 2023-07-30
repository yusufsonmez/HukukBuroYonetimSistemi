using HukukBuroYonetimSistemi.Data;
using HukukBuroYonetimSistemi.Models.Domain;
using Microsoft.EntityFrameworkCore;

namespace BaseProject.Repositories
{
    public class UserRepository
    {
        public MahkemeDbContext _mahkemeDbContext { get; set; }
        public UserRepository(MahkemeDbContext mahkemeDbContext) 
        {
            _mahkemeDbContext = mahkemeDbContext;
        }
        public List<Mahkemeler> GetUserByUserId(int userId)
        {
            return null;
        }
        public List<Users> GetUsers()
        {
            var users = _mahkemeDbContext.Users.ToList();

            return users;
        }
    }
}
    
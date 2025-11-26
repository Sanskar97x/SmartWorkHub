using SmartWorkHub.Application.Interfaces;
using SmartWorkHub.Domain.Entities;

namespace SmartWorkHub.Infrastructure.Repositories
{
    public class UserRepository : IUserRepository
    {
        public void Add(User user) { }
        public List<User> GetAll() => new();
        public User GetById(int id) => new();
    }
}
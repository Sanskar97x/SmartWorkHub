using SmartWorkHub.Domain.Entities;

namespace SmartWorkHub.Application.Interfaces
{
    public interface IUserRepository
    {
        User GetById(int id);
        List<User> GetAll();
        void Add(User user);
    }
}

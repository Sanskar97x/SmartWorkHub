using SmartWorkHub.Application.Interfaces;

namespace SmartWorkHub.Application.Services
{
    public class UserService
    {
        private readonly IUserRepository _repo;

        public UserService(IUserRepository repo)
        {
            _repo = repo;
        }
    }
}
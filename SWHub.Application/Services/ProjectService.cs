using SmartWorkHub.Application.Interfaces;

namespace SmartWorkHub.Application.Services
{
    public class ProjectService
    {
        private readonly IProjectRepository _repo;

        public ProjectService(IProjectRepository repo)
        {
            _repo = repo;
        }
    }
}
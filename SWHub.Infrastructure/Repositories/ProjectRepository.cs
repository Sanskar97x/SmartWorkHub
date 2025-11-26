using SmartWorkHub.Application.Interfaces;
using SmartWorkHub.Domain.Entities;

namespace SmartWorkHub.Infrastructure.Repositories
{
    public class ProjectRepository : IProjectRepository
    {
        public void Add(Project project) { }
        public List<Project> GetAll() => new();
        public Project GetById(int id) => new();
    }
}
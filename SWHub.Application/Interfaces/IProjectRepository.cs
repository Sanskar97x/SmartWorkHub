using SmartWorkHub.Domain.Entities;

namespace SmartWorkHub.Application.Interfaces
{
    public interface IProjectRepository
    {
        Project GetById(int id);
        List<Project> GetAll();
        void Add(Project project);
    }
}

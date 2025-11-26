using SmartWorkHub.Domain.Entities;

namespace SmartWorkHub.Application.Interfaces
{
    public interface ITaskRepository
    {
        TaskItem GetById(int id);
        void Add(TaskItem task);
    }
}

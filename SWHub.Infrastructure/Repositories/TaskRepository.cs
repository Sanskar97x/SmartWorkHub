using SmartWorkHub.Application.Interfaces;
using SmartWorkHub.Domain.Entities;

namespace SmartWorkHub.Infrastructure.Repositories
{
    public class TaskRepository : ITaskRepository
    {
        public void Add(TaskItem task) { }
        public TaskItem GetById(int id) => new();
    }
}
using SmartWorkHub.Application.Interfaces;

namespace SmartWorkHub.Application.Services
{
    public class TaskService
    {
        private readonly ITaskRepository _repo;

        public TaskService(ITaskRepository repo)
        {
            _repo = repo;
        }
    }
}
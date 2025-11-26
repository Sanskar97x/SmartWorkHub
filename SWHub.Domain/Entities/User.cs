namespace SmartWorkHub.Domain.Entities
{
    public class User
    {
        public int Id { get; set; }
        public string FullName { get; set; } = null!;
        public string Email { get; set; } = null!;

        public int? TeamId { get; set; }
        public Team? Team { get; set; }

        public ICollection<TaskItem>? AssignedTasks { get; set; }
        public ICollection<Project>? CreatedProjects { get; set; }
    }}
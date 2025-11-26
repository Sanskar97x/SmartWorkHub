namespace SmartWorkHub.Domain.Entities
{
    public class Project
    {
        public int Id { get; set; }
        public string Title { get; set; } = null!;
        public string? Description { get; set; }

        public int TeamId { get; set; }
        public Team Team { get; set; } = null!;

        public int CreatedByUserId { get; set; }
        public User CreatedByUser { get; set; } = null!;

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        public ICollection<TaskItem>? Tasks { get; set; }
    }
}
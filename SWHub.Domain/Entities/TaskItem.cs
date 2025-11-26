namespace SmartWorkHub.Domain.Entities
{
    public class TaskItem
    {
        public int Id { get; set; }
        public string Title { get; set; } = null!;
        public string? Description { get; set; }

        public int ProjectId { get; set; }
        public Project Project { get; set; } = null!;

        public int AssignedToUserId { get; set; }
        public User AssignedToUser { get; set; } = null!;

        public string Status { get; set; } = "Pending"; // Pending, InProgress, Completed
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public DateTime? DueDate { get; set; }
    }
}
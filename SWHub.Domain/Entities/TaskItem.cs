using System;
using SmartWorkHub.Domain.Common;
using SmartWorkHub.Domain.Enums;

namespace SmartWorkHub.Domain.Entities
{
    public class TaskItem : AuditableEntity
    {
        // Core properties
        public string Title { get; set; } = null!;
        public string? Description { get; set; }
        public TaskStatus Status { get; set; } = TaskStatus.Todo;
        public TaskPriority Priority { get; set; } = TaskPriority.Medium;
        public DateTime? DueDate { get; set; }

        // Foreign Keys
        public Guid ProjectId { get; set; }
        public Guid AssignedToId { get; set; }

        // Navigation properties
        public Project Project { get; set; } = null!;
        public User AssignedTo { get; set; } = null!;
    }
}

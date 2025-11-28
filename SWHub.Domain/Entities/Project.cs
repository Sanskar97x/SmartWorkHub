using System;
using System.Collections.Generic;
using SmartWorkHub.Domain.Common;

namespace SmartWorkHub.Domain.Entities
{
    public class Project : AuditableEntity
    {
        public string Name { get; set; } = null!;
        public string? Description { get; set; }

        // Foreign Keys
        public Guid WorkspaceId { get; set; }
        public Guid OwnerId { get; set; }

        // Navigation properties
        public Workspace Workspace { get; set; } = null!;
        public User Owner { get; set; } = null!;
        public List<TaskItem> Tasks { get; set; } = new();
    }
}

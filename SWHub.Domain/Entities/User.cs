using System;
using System.Collections.Generic;
using SmartWorkHub.Domain.Common;

namespace SmartWorkHub.Domain.Entities
{
    public class User : AuditableEntity
    {
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public string Email { get; set; } = null!;
        public string PasswordHash { get; set; } = null!;

        // Navigation properties
        public List<Project> Projects { get; set; } = new();
        public List<TaskItem> AssignedTasks { get; set; } = new();
    }
}

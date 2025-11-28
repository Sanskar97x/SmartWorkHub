using System;
using System.Collections.Generic;
using SmartWorkHub.Domain.Common;

namespace SmartWorkHub.Domain.Entities
{
  public class Workspace : AuditableEntity
  {
    public string Name { get; set; } = null!;
    public string? Description { get; set; }

    // Navigation property
    public List<Project> Projects { get; set; } = new();
  }
}

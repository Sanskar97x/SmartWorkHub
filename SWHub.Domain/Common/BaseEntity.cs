using System;
using System.Collections.Generic;

namespace SmartWorkHub.Domain.Common
{
  public abstract class BaseEntity
  {
    public Guid Id { get; protected set; } = Guid.NewGuid();

    // For future domain events (optional now)
    public List<object> DomainEvents { get; private set; } = new List<object>();
  }
}

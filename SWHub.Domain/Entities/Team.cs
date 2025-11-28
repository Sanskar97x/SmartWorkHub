namespace SmartWorkHub.Domain.Entities
{
    public class Team
    {
        public int TeamId { get; set; }
        public string Name { get; set; } = string.Empty;
        public int CreatedByUserId { get; set; } // FK → Users
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}

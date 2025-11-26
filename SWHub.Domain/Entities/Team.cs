namespace SmartWorkHub.Domain.Entities
{
    public class Team
    {
        public int Id { get; set; }
        public string TeamName { get; set; } = null!;

        public ICollection<User>? Users { get; set; }
        public ICollection<Project>? Projects { get; set; }
    }
}

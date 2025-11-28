namespace SmartWorkHub.Domain.ValueObjects
{
    public class FullName
    {
        public string FirstName { get; }
        public string LastName { get; }

        public FullName(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        // Optional: override ToString()
        public override string ToString() => $"{FirstName} {LastName}";
    }
}

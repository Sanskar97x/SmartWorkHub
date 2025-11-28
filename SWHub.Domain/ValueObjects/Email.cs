namespace SmartWorkHub.Domain.ValueObjects
{
    public class Email
    {
        public string Address { get; }

        public Email(string address)
        {
            // Optional: validate email format
            Address = address;
        }

        public override string ToString() => Address;
    }
}

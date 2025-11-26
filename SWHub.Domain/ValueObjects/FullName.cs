namespace SmartWorkHub.Domain.ValueObjects
{
    public class FullName
    {
        public string First { get; private set; }
        public string Last { get; private set; }

        public FullName(string first, string last)
        {
            First = first;
            Last = last;
        }
    }
}
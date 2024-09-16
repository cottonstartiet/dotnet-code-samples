namespace MultithreadedListAccess.Models
{
    internal class User
    {
        public required int Id { get; set; }
        public required string Name { get; set; }
        public bool IsGamePassSubscriber { get; set; }
        public int HoursPlayed { get; set; }
    }
}

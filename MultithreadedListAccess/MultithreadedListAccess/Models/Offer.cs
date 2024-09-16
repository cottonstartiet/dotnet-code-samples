namespace MultithreadedListAccess.Models
{
    internal class Offer
    {
        public required int Id { get; set; }
        public required string Name { get; set; }
        public bool IsAVailableForGamePass { get; set; }
        public int HoursPlayed { get; set; }
    }
}

namespace FourTierAppSample.Models
{
    public class UserProfile
    {
        public string? Name { get; internal set; }
        public string? Email { get; internal set; }
        public IList<WishlistItem>? Wishlist { get; internal set; }
    }
}
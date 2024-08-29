using FourTierAppSample.Models;

namespace FourTierAppSample.BusinessLogic
{
    public class WishlistInfoDomainData
    {
        private readonly WishlistService wishlistService;

        public WishlistInfoDomainData(WishlistService wishlistService)
        {
            this.wishlistService = wishlistService;
        }

        internal IList<WishlistItem> GetWishlistInfoById(string userId)
        {
            return wishlistService.GetWisshlistForUser(userId);
        }
    }
}
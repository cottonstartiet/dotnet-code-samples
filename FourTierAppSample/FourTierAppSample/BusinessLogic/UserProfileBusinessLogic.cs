using FourTierAppSample.Models;

namespace FourTierAppSample.BusinessLogic
{
    public class UserProfileBusinessLogic
    {
        private readonly WishlistInfoDomainData wishlistInfo;
        private readonly UserInfoDomainData userInfo;

        public UserProfileBusinessLogic(
            WishlistInfoDomainData wishlistInfo,
            UserInfoDomainData userInfo
            )
        {
            this.wishlistInfo = wishlistInfo;
            this.userInfo = userInfo;
        }

        public UserProfile GetUserProfileById(string userId)
        {
            UserProfile info = userInfo.GetUserInfoById(userId);
            IList<WishlistItem> wishlist = wishlistInfo.GetWishlistInfoById(userId);
            return new UserProfile()
            {
                Name = info.Name,
                Email = info.Email,
                Wishlist = wishlist
            };
        }
    }
}
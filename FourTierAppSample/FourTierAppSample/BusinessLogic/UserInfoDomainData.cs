
using FourTierAppSample.DataAccess;
using FourTierAppSample.Models;

namespace FourTierAppSample.BusinessLogic
{
    public class UserInfoDomainData
    {
        private readonly UserProfileCosmosDb userProfileCosmosDb;

        public UserInfoDomainData(UserProfileCosmosDb userProfileCosmosDb)
        {
            this.userProfileCosmosDb = userProfileCosmosDb;
        }

        internal UserProfile GetUserInfoById(string userId)
        {

        }
    }
}
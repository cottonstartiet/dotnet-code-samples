using UserProfileApi.Storage.Contract;

namespace UserProfileApi.Storage
{
    public class UserProfileCosmosClient
    {
        public UserProfileDataContract GetUserById(string userId)
        {
            return new UserProfileDataContract()
            {
                Id = userId
            };
        }
    }
}

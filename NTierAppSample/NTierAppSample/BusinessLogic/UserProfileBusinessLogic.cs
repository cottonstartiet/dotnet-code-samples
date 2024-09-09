using UserProfileApi.BusinessLogic.Mapper;
using UserProfileApi.Models;
using UserProfileApi.Storage;

namespace UserProfileApi.BusinessLogic
{
    public class UserProfileBusinessLogic
    {
        private readonly UserProfileCosmosClient userProfileCosmosClient;

        public UserProfileBusinessLogic(UserProfileCosmosClient userProfileCosmosClient)
        {
            this.userProfileCosmosClient = userProfileCosmosClient;
        }

        public UserProfileInfo GetUserProfile(string userId)
        {
            Storage.Contract.UserProfileDataContract user = userProfileCosmosClient.GetUserById(userId);
            return UserProfileInfoMapper.MapFrom(user);
        }
    }
}

using UserProfileApi.Models;
using UserProfileApi.Storage.Contract;

namespace UserProfileApi.BusinessLogic.Mapper
{
    public class UserProfileInfoMapper
    {
        public static UserProfileInfo MapFrom(UserProfileDataContract userProfileDataContract)
        {
            return new UserProfileInfo()
            {
                UserId = userProfileDataContract.Id
            };

        }
    }
}

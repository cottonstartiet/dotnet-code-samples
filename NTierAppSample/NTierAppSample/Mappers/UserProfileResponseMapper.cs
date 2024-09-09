using UserProfile.Shared.Contract;
using UserProfileApi.Models;

namespace UserProfileApi.Mappers
{
    public class UserProfileResponseMapper
    {
        public static UserProfileResponse MapFrom(UserProfileInfo userProfileInfo)
        {
            return new UserProfileResponse()
            {
                UId = userProfileInfo.UserId
            };
        }
    }
}

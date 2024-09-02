using UserProfile.Shared.Contract;
using UserProfileApi.Models;

namespace UserProfileApi.Mappers
{
    public class UserProfileMapper
    {
        public static UserProfileResponse MapFrom(UserProfileInfo userProfileInfo)
        {
            return new UserProfileResponse();
        }
    }
}

using FourTierAppSample.Controllers.Dto;
using FourTierAppSample.Models;

namespace FourTierAppSample.Controllers.Mapper
{
    public static class UserProfileToDtoMapper
    {
        public static UserProfileResponse Map(UserProfile userProfile)
        {
            return new UserProfileResponse();
        }
    }
}

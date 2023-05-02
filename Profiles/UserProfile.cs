using AutoMapper;
using Solution.Dtos.UserDtos;

namespace Solution.Models.Profiles
{
    public class UserProfile : Profile
    {
        public UserProfile()
        {
            CreateMap<UserCreatedDto, UserModel>();

            CreateMap<UserModel, UserReadDto>();

            CreateMap<UserUpdateDto, UserModel>();
        }
    }
}
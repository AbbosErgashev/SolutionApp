using AutoMapper;
using Solution.Dtos.CommandDtos;

namespace Solution.Models.Profiles
{
    public class CommandsProfile : Profile  //not use in project this file
    {
        public CommandsProfile()
        {
            CreateMap<CommandCreatedDto, Command>();

            CreateMap<Command, CommandReadDto>();

            CreateMap<CommandUpdateDto, Command>();
        }
    }
}
using Solution.Models.Base;

namespace Solution.Dtos.CommandDtos
{
    public class CommandReadDto : BaseModel //not use in project this file
    {
        public string HowTo { get; set; }

        public string Platform { get; set; }

        public string CommandLine { get; set; }
    }
}
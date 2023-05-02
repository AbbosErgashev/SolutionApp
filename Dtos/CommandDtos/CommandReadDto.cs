using Solution.Models.Base;

namespace Solution.Dtos.CommandDtos
{
    public class CommandReadDto : BaseModel
    {
        public string HowTo { get; set; }

        public string Platform { get; set; }

        public string CommandLine { get; set; }
    }
}
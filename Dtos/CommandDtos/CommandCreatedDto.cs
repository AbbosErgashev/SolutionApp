using System.ComponentModel.DataAnnotations;

namespace Solution.Dtos.CommandDtos
{
    public class CommandCreatedDto  //not use in project this file
    {
        [Required]
        [MaxLength(250)]
        public string HowTo { get; set; }

        [Required]
        public string Platform { get; set; }

        [Required]
        public string CommandLine { get; set; }
    }
}
using System.ComponentModel.DataAnnotations;
using Solution.Models.Base;

namespace Solution.Models
{
    public class Command : BaseModel
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

using System.Text.Json.Serialization;
using System.ComponentModel.DataAnnotations;
using Solution.Models.Base;

namespace Solution.Models
{
    public class UserModel : BaseModel
    {
        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        [Required]
        public string Password { get; set; }

        [JsonIgnore]
        public bool IsActive { get; set; }
    }
}
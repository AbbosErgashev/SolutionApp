using System.ComponentModel.DataAnnotations;

namespace Solution.Models.User
{
    public class UserLoginModel
    {
        [Required]
        public string UserName { get; set; }

        [Required]
        public string Password { get; set; }
    }
}
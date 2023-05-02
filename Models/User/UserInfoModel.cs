using Solution.Models.Base;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace Solution.Models.User
{
    public class UserInfoModel : BaseModel
    {
        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        [Required]
        public string UserName { get; set; }

        public List<string> Permissions { get; set; }
    }
}
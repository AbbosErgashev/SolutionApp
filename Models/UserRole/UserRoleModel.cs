using Solution.Models.Base;
using System.Text.Json.Serialization;
using System.Collections.Generic;

namespace Solution.Models.UserRole
{
    public class UserRoleModels : BaseModel
    {
        [JsonIgnore]
        public int UserId { get; set; }

        [JsonIgnore]
        public int RoleId { get; set; }

        [JsonIgnore]
        public List<UserModel> UserModels { get; set; }
    }
}
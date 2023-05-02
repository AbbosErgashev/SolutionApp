using System.ComponentModel.DataAnnotations;

namespace Solution.Models.User
{
    public class UserAccessModel
    {
        [Required]
        public int UserId { get; set; }

        [Required]
        public int RoleId { get; set; }

        [Required]
        public bool IsActive { get; set; }
    }
}
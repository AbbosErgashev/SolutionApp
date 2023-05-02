using System;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Solution.Models.User
{
    public class LoginTokenModel
    {
        public string Token { get; set; }

        [DataType(DataType.Date)]
        public DateTime Expiration { get; set; }

        [JsonIgnore]
        public bool IsActive { get; set; }
    }
}
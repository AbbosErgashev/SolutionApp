using System.Collections.Generic;

namespace Solution.SolutionConstants.Permissions
{
    public static class USER
    {
        public const string GET = "user.get";
        public const string CREATE = "user.create";
        public const string DELETE = "user.delete";
        public const string UPDATE = "user.update";
        public const string ACCESS = "user.access";

        public static List<dynamic> All()
        {
            List<dynamic> allPermissions = new List<dynamic>
            {
                new { label = "GET", value = USER.GET },
                new { label = "CREATE", value = USER.CREATE},
                new { label = "DELETE", value = USER.DELETE},
                new { label = "UPDATE", value = USER.UPDATE},
                new { label = "CONTROL", value = USER.ACCESS}
            };
            return allPermissions;
        }

        public static List<string> AllList()
        {
            return new List<string>() { GET, CREATE, DELETE, UPDATE, ACCESS };
        }
        public static Dictionary<string, string> GetUserPermissions()
        {
            Dictionary<string, string> result = new Dictionary<string, string>()
            {
                {"GET", USER.GET},
                {"CREATE", USER.CREATE},
                {"DELETE", USER.DELETE},
                {"UPDATE", USER.UPDATE},
                {"CONTROL", USER.ACCESS}
            };
            return result;
        }
    }
}
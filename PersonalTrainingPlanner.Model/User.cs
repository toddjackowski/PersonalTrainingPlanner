using System.Collections.Generic;

namespace PersonalTrainingPlanner.Model
{
    public class User
    {
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public List<Role> Roles { get; set; }
    }
}

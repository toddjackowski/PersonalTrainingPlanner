namespace PersonalTrainingPlanner.Model
{
    public class Role
    {
        public int RoleId { get; set; }
        public string Name { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
    }
}

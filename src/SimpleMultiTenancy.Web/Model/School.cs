namespace SimpleMultiTenancy.Web
{
    public class School
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public ICollection<UserRole> UserRoles { get; set; }
        public ICollection<Grade> Grades { get; set; }
    }
}
namespace SimpleMultiTenancy.Web
{
    public class School
    {
        public string Id { get; set; }
        public string Name { get; set; }

        public ICollection<UserRole> UserRoles { get; set; }
    }
}
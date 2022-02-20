namespace SimpleMultiTenancy.Web.ViewModels
{
    public class RoleInCompany
    {
        public Company Company { get; set; }
        public string Name { get; set; }

        public override string ToString() => $"{Company.Id}:{Name}";
    }
}
namespace SimpleMultiTenancy.Web.ViewModels
{
    public class RoleInCompany
    {
        public School Company { get; set; }
        public string Name { get; set; }

        public override string ToString() => $"{Company.Id}:{Name}";
    }
}
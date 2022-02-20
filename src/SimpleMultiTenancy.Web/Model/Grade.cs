namespace SimpleMultiTenancy.Web
{
    public class Grade
    {
        public int Id { get; set; }

        public int SchoolId { get; set; }
        public School School { get; set; }

        public string Subject { get; set; }
        public int Value { get; set; }

        public string UserId { get; set; }
        public User Student { get; set; }
    }
}
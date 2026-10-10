namespace WebApplication_Templates.Models
{
    public class MasterCertificates:BaseEntity
    {
        public string Title { get; set; }
        public string MembershipId { get; set; }
        public string ImageURL { get; set; }
        public DateTime Date { get; set; }
    }
}

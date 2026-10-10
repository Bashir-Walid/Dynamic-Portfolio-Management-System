namespace WebApplication_Templates.Models
{
    public class MasterExperience:BaseEntity
    {
        public int StartYear { get; set; }
        public string Title { get; set; }
        public string Desc { get; set; }
        public int EndYear { get; set; }
    }
}

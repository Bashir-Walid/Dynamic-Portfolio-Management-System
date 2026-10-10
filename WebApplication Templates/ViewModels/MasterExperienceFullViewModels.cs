namespace WebApplication_Templates.ViewModels
{
    public class MasterExperienceFullViewModels
    {
        public int StartYear { get; set; }
        public string Title { get; set; }
        public string Desc { get; set; }
        public int EndYear { get; set; }
        public bool IsActive { get; set; }
        public int Id { get; set; }
        public bool IsDelete { get; set; }
        public bool IsDeleted { get; internal set; }
        public List<MasterExperienceViewModels> list { get; set; }
        public int DeleteId { get; set; }
    }
}

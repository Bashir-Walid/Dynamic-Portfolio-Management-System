namespace WebApplication_Templates.ViewModels
{
    public class MasterContactUsFullViewModels
    {
        public string Icon { get; set; }
        public string Link { get; set; }
        public string Title { get; set; }
        public bool IsActive { get; set; }
        public int Id { get; set; }
        public List<MasterContactUsViewModels> list { get; set; }
        public bool IsDelete { get; set; }
        public bool IsDeleted { get; set; }
        public int DeleteId { get; set; }
    }
}

namespace WebApplication_Templates.ViewModels
{
    public class MasterTitlesFullViewModels
    {
        public string Title { get; set; }
        public string Keyword { get; set; }
        public bool IsActive { get; set; }
        public int Id { get; set; }
        public List<MasterTitlesViewModels> list { get; set; }
        public bool IsDelete { get; set; }
        public bool IsDeleted { get; set; }
        public int DeleteId { get; set; }
    }
}

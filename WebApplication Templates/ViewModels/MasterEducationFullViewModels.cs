namespace WebApplication_Templates.ViewModels
{
    public class MasterEducationFullViewModels
    {
        public string University { get; set; }
        public string Title { get; set; }
        public string Desc { get; set; }
        public int Year { get; set; }
        public bool IsActive { get; set; }
        public int Id { get; set; }
        public bool IsDelete { get; set; }
        public bool IsDeleted { get; internal set; }
        public List<MasterEducationViewModels> list { get; set; }
        public int DeleteId { get; set; }
    }
}

namespace WebApplication_Templates.ViewModels
{
    public class MasterFactsFullViewModels
    {
        public string Title { get; set; }
        public string Icon { get; set; }
        public bool IsActive { get; set; }
        public int Id { get; set; }

        public string Number { get; set; }
        public List<MasterFactsViewModels> list { get; set; }
        public bool IsDelete { get; set; }
        public bool IsDeleted { get; set; }
        public int DeleteId { get; set; }
    }
}

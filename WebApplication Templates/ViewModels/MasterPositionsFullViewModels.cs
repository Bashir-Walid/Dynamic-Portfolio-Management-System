namespace WebApplication_Templates.ViewModels
{
    public class MasterPositionsFullViewModels
    {
        public string Name { get; set; }
        public bool IsPrimary { get; set; }
        public int Id { get; set; }

        public bool IsActive { get; set; }
        public bool IsDelete { get; set; }
        public bool IsDeleted { get; internal set; }
        public List<MasterPositionsViewModels> list { get; set; }
        public int DeleteId { get; set; }
    }
}
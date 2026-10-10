namespace WebApplication_Templates.ViewModels
{
    public class MasterServicesFullViewModels
    {
        public string Icon { get; set; }
        public string Name { get; set; }
        public string Desc { get; set; }
        public int Id { get; set; }
        public bool IsActive { get; set; }
        public List<MasterServicesViewModels> list { get; set; }
        public bool IsDelete { get; set; }
        public bool IsDeleted { get; set; }
        public int DeleteId { get; set; }

    }
}

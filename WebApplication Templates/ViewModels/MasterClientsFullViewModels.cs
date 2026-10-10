namespace WebApplication_Templates.ViewModels
{
    public class MasterClientsFullViewModels
    {
        public string? ImageURL { get; set; }
        public IFormFile? ImageFile { get; set; }
        public int Id { get; set; }
        public bool IsActive { get; set; }
        public bool IsDelete { get; set; }
        public bool IsDeleted { get; internal set; }
        public List<MasterClientsViewModels> list { get; set; }
        public int DeleteId { get; set; }
    }
}

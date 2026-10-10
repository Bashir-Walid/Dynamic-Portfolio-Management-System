namespace WebApplication_Templates.ViewModels
{
    public class MasterCertificatesFullViewModels
    {
        public string Title { get; set; }
        public string MembershipId { get; set; }
        public string? ImageURL { get; set; }
        public DateTime? Date { get; set; }
        public int Id { get; set; }
        public bool IsDelete { get; set; }
        public bool IsDeleted { get; internal set; }
        public List<MasterCertificatesViewModels> list { get; set; }
        public int DeleteId { get; set; }
        public IFormFile? ImageFile { get; set; }
        public bool IsActive { get; set; }
    }
}


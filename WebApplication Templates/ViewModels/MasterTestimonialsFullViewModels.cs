namespace WebApplication_Templates.ViewModels
{
    public class MasterTestimonialsFullViewModels
    {
        public string Name { get; set; }
        public string Desc { get; set; }
        public string? ImageURL { get; set; }
        public IFormFile? ImageFile { get; set; }
        public string Title { get; set; }
        public int Id { get; set; }
        public bool IsActive { get; set; }
        public bool IsDelete { get; set; }
        public bool IsDeleted { get; internal set; }
        public List<MasterTestimonialsViewModels> list { get; set; }
        public int DeleteId { get; set; }
    }
}

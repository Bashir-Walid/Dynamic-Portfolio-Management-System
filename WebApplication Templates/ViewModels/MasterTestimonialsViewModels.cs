namespace WebApplication_Templates.ViewModels
{
    public class MasterTestimonialsViewModels
    {
        public string Name { get; set; }
        public string Desc { get; set; }
        public string? ImageURL { get; set; }
        public IFormFile? ImageFile { get; set; }
        public string Title { get; set; }
        public int Id { get; set; }
        public bool IsActive { get; set; }
    }
}

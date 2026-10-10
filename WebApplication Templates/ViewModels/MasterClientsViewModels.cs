namespace WebApplication_Templates.ViewModels
{
    public class MasterClientsViewModels
    {
        public string? ImageURL { get; set; }
        public IFormFile? ImageFile { get; set; }
        public int Id { get; set; }
        public bool IsActive { get; set; }
    }
}

using WebApplication_Templates.Models;

namespace WebApplication_Templates.ViewModels
{
    public class MasterPortfolioViewModels
    {
        public string Title { get; set; }
        public int CategoryId { get; set; }
        public string? ThumbnailImg { get; set; }
        public string? ViewImg { get; set; }
        public bool IsActive { get; set; }
        public int Id { get; set; }
        public IFormFile? ImageFile { get; set; }


    }
}

namespace WebApplication_Templates.ViewModels
{
    public class MasterPortfolioFullViewModels
    {
        public string Title { get; set; }
        public int CategoryId { get; set; }
        public string? ThumbnailImg { get; set; }
        public string? ViewImg { get; set; }
        public bool IsActive { get; set; }
        public int Id { get; set; }
        public bool IsDelete { get; set; }
        public bool IsDeleted { get; internal set; }
        public List<MasterPortfolioViewModels> list { get; set; }
        public List<MasterCategoryViewModels> listet { get; set; }
        public string Name { get; set; }
        public string Icon { get; set; }
        public int DeleteId { get; set; }
        public IFormFile? ImageFile { get; set; }

    }
}

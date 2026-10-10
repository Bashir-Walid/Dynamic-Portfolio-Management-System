using WebApplication_Templates.Models;
using WebApplication_Templates.ViewModels;

namespace WebApplication_Templates.Extensions
{
    public static class MasterPortfolioMappingExtension
    {
        public static MasterPortfolio ToModel(this MasterPortfolioViewModels model)
        {
            return new MasterPortfolio
            {
                IsActive = model.IsActive,
                CategoryId = model.CategoryId,
                Id = model.Id,
                Title = model.Title,
                ThumbnailImg = model.ThumbnailImg,
                ViewImg=model.ViewImg,

            };
        }
        public static MasterPortfolioViewModels ToViewModel(this MasterPortfolio model)
        {
            return new MasterPortfolioViewModels
            {
                IsActive = model.IsActive,
                CategoryId = model.CategoryId,
                Id = model.Id,
                Title = model.Title,
                ThumbnailImg = model.ThumbnailImg,
                ViewImg = model.ViewImg,

            };
        }
        public static List<MasterPortfolioViewModels> ToViewModelList(this List<MasterPortfolio> model)
        {
            return model.Select(x => x.ToViewModel()).ToList();

        }
        public static List<MasterPortfolio> ToModelList(this List<MasterPortfolioViewModels> model)
        {
            return model.Select(x => x.ToModel()).ToList();

        }
    }
}

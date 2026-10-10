using WebApplication_Templates.Models;
using WebApplication_Templates.ViewModels;

namespace WebApplication_Templates.Extensions
{
    public static class MasterCategoryMappingExtension
    {
        public static MasterCategory ToModel(this MasterCategoryViewModels model)
        {
            return new MasterCategory
            {
                IsActive = model.IsActive,
                Id = model.Id,
                Name = model.Name,
                Icon = model.Icon,
               

            };
        }
        public static MasterCategoryViewModels ToViewModel(this MasterCategory model)
        {
            return new MasterCategoryViewModels
            {
                IsActive = model.IsActive,
                Id = model.Id,
                Name = model.Name,
                Icon = model.Icon,
            };
        }
        public static List<MasterCategoryViewModels> ToViewModelList(this List<MasterCategory> model)
        {
            return model.Select(x => x.ToViewModel()).ToList();

        }
        public static List<MasterCategory> ToModelList(this List<MasterCategoryViewModels> model)
        {
            return model.Select(x => x.ToModel()).ToList();

        }
    }
}



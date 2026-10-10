using WebApplication_Templates.Models;
using WebApplication_Templates.ViewModels;

namespace WebApplication_Templates.Extensions
{
    public static class MasterContactUsMappingExtension
    {
        public static MasterContactUs ToModel(this MasterContactUsViewModels model)
        {
            return new MasterContactUs
            {
                IsActive = model.IsActive,
                Id = model.Id,
                Link = model.Link,
                Icon= model.Icon,
                Title = model.Title,


            };
        }
        public static MasterContactUsViewModels ToViewModel(this MasterContactUs model)
        {
            return new MasterContactUsViewModels
            {
                IsActive = model.IsActive,
                Id = model.Id,
                Link = model.Link,
                Icon = model.Icon,
                Title= model.Title,
            };
        }
        public static List<MasterContactUsViewModels> ToViewModelList(this List<MasterContactUs> model)
        {
            return model.Select(x => x.ToViewModel()).ToList();

        }
        public static List<MasterContactUs> ToModelList(this List<MasterContactUsViewModels> model)
        {
            return model.Select(x => x.ToModel()).ToList();

        }
    }
}

using WebApplication_Templates.Models;
using WebApplication_Templates.ViewModels;

namespace WebApplication_Templates.Extensions
{
    public static class MasterServicesMappingExtension
    {
        public static MasterServices ToModel(this MasterServicesViewModels model)
        {
            return new MasterServices
            {
                IsActive = model.IsActive,
                Id = model.Id,
                Name = model.Name,
                Icon = model.Icon,
                Desc= model.Desc
               

            };
        }
        public static MasterServicesViewModels ToViewModel(this MasterServices model)
        {
            return new MasterServicesViewModels
            {
                IsActive = model.IsActive,
                Id = model.Id,
                Name = model.Name,
                Icon = model.Icon,
                Desc = model.Desc
            };
        }
        public static List<MasterServicesViewModels> ToViewModelList(this List<MasterServices> model)
        {
            return model.Select(x => x.ToViewModel()).ToList();

        }
        public static List<MasterServices> ToModelList(this List<MasterServicesViewModels> model)
        {
            return model.Select(x => x.ToModel()).ToList();

        }
    }
}



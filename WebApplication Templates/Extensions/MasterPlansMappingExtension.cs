using WebApplication_Templates.Models;
using WebApplication_Templates.ViewModels;

namespace WebApplication_Templates.Extensions
{
    public static class MasterPlansMappingExtension
    {
        public static MasterPlans ToModel(this MasterPlansViewModels model)
        {
            return new MasterPlans
            {
                IsActive = model.IsActive,
                Name = model.Name,
                Id = model.Id,
                IsSuggested= model.IsSuggested,
                PricePeriod= model.PricePeriod,
                Price= model.Price,

            };
        }
        public static MasterPlansViewModels ToViewModel(this MasterPlans model)
        {
            return new MasterPlansViewModels
            {
                IsActive = model.IsActive,
                Name = model.Name,
                Id = model.Id,
                IsSuggested = model.IsSuggested,
                PricePeriod = model.PricePeriod,
                Price = model.Price,

            };
        }
        public static List<MasterPlansViewModels> ToViewModelList(this List<MasterPlans> model)
        {
            return model.Select(x => x.ToViewModel()).ToList();

        }
        public static List<MasterPlans> ToModelList(this List<MasterPlansViewModels> model)
        {
            return model.Select(x => x.ToModel()).ToList();

        }
    }
}

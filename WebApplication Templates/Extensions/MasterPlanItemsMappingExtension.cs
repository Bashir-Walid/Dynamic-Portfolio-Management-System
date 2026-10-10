using WebApplication_Templates.Models;
using WebApplication_Templates.ViewModels;

namespace WebApplication_Templates.Extensions
{
    public static class MasterPlanItemsMappingExtension
    {
        public static MasterPlanItems ToModel(this MasterPlanItemsViewModels model)
        {
            return new MasterPlanItems
            {
                IsActive = model.IsActive,
                PlanId = model.PlanId,
                Id = model.Id,
                Desc=model.Desc,
            };
        }
        public static MasterPlanItemsViewModels ToViewModel(this MasterPlanItems model)
        {
            return new MasterPlanItemsViewModels
            {
                IsActive = model.IsActive,
                PlanId = model.PlanId,
                Id = model.Id,
                Desc = model.Desc,

            };
        }
        public static List<MasterPlanItemsViewModels> ToViewModelList(this List<MasterPlanItems> model)
        {
            return model.Select(x => x.ToViewModel()).ToList();

        }
        public static List<MasterPlanItems> ToModelList(this List<MasterPlanItemsViewModels> model)
        {
            return model.Select(x => x.ToModel()).ToList();

        }
    }
}

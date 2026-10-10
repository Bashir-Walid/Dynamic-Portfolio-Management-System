using WebApplication_Templates.Models;
using WebApplication_Templates.ViewModels;

namespace WebApplication_Templates.Extensions
{
    public static class MasterPositionsMappingExtension
    {
        public static MasterPositions ToModel(this MasterPositionsViewModels model)
        {
            return new MasterPositions
            {
                IsActive = model.IsActive,
                IsPrimary = model.IsPrimary,
                Name = model.Name,
                Id=model.Id

            };
        }
        public static MasterPositionsViewModels ToViewModel(this MasterPositions model)
        {
            return new MasterPositionsViewModels
            {
                IsActive = model.IsActive,
                IsPrimary = model.IsPrimary,
                Name = model.Name,
                Id = model.Id

            };
        }
        public static List<MasterPositionsViewModels> ToViewModelList(this List<MasterPositions> model)
        {
            return model.Select(x =>x.ToViewModel()).ToList();
        
        }
        public static List<MasterPositions> ToModelList(this List<MasterPositionsViewModels> model)
        {
            return model.Select(x => x.ToModel()).ToList();

        }
    }
}

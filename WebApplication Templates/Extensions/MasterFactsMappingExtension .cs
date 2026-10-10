using WebApplication_Templates.Models;
using WebApplication_Templates.ViewModels;

namespace WebApplication_Templates.Extensions
{
    public static class MasterFactsMappingExtension
    {
        public static MasterFacts ToModel(this MasterFactsViewModels model)
        {
            return new MasterFacts
            {
                IsActive = model.IsActive,
                Id = model.Id,
                Icon = model.Icon,
                Title = model.Title,
                Number = model.Number,
            };
        }
        public static MasterFactsViewModels ToViewModel(this MasterFacts model)
        {
            return new MasterFactsViewModels
            {
                IsActive = model.IsActive,
                Id = model.Id,
                Icon = model.Icon,
                Title= model.Title,
                Number= model.Number,
            };
        }
        public static List<MasterFactsViewModels> ToViewModelList(this List<MasterFacts> model)
        {
            return model.Select(x => x.ToViewModel()).ToList();

        }
        public static List<MasterFacts> ToModelList(this List<MasterFactsViewModels> model)
        {
            return model.Select(x => x.ToModel()).ToList();

        }
    }
}

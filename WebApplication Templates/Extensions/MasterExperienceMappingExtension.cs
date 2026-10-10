using WebApplication_Templates.Models;
using WebApplication_Templates.ViewModels;

namespace WebApplication_Templates.Extensions
{
    public static class MasterExperienceMappingExtensions
    {
        public static MasterExperience ToModel(this MasterExperienceViewModels model)
        {
            return new MasterExperience
            {
                
               StartYear = model.StartYear,
               EndYear = model.EndYear,
               Title= model.Title,
               Desc= model.Desc,
               Id= model.Id,
               IsActive= model.IsActive,
            };
        }
        public static MasterExperienceViewModels ToViewModel(this MasterExperience model)
        {
            return new MasterExperienceViewModels
            {
                StartYear = model.StartYear,
                EndYear = model.EndYear,
                Title = model.Title,
                Desc = model.Desc,
                Id = model.Id,
                IsActive = model.IsActive,

            };
        }
        public static List<MasterExperienceViewModels> ToViewModelList(this List<MasterExperience> model)
        {
            return model.Select(x => x.ToViewModel()).ToList();

        }
        public static List<MasterExperience> ToModelList(this List<MasterExperienceViewModels> model)
        {
            return model.Select(x => x.ToModel()).ToList();

        }
    }
}



using WebApplication_Templates.Models;
using WebApplication_Templates.ViewModels;

namespace WebApplication_Templates.Extensions
{
    public static class MasterEducationMappingExtensions
    {
        public static MasterEducation ToModel(this MasterEducationViewModels model)
        {
            return new MasterEducation
            {
                
                IsActive = model.IsActive,
                Id = model.Id,
                Year= model.Year,
                Desc= model.Desc,
                Title= model.Title,
                University= model.University,

            };
        }
        public static MasterEducationViewModels ToViewModel(this MasterEducation model)
        {
            return new MasterEducationViewModels
            {
                IsActive = model.IsActive,
                Id = model.Id,
                Year = model.Year,
                Desc = model.Desc,
                Title = model.Title,
                University = model.University,

            };
        }
        public static List<MasterEducationViewModels> ToViewModelList(this List<MasterEducation> model)
        {
            return model.Select(x => x.ToViewModel()).ToList();

        }
        public static List<MasterEducation> ToModelList(this List<MasterEducationViewModels> model)
        {
            return model.Select(x => x.ToModel()).ToList();

        }
    }
}



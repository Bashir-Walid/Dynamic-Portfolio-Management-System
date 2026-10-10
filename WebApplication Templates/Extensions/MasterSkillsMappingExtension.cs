using WebApplication_Templates.Models;
using WebApplication_Templates.ViewModels;

namespace WebApplication_Templates.Extensions
{
    public static class MasterSkillsMappingExtensions
    {
        public static MasterSkills ToModel(this MasterSkillsViewModels model)
        {
            return new MasterSkills
            {

                IsSoftSkill = model.IsSoftSkill,
                IsKnowledge = model.IsKnowledge,
                Percentage = model.Percentage,
                Name = model.Name,
               Id= model.Id,
               IsActive= model.IsActive,
            };
        }
        public static MasterSkillsViewModels ToViewModel(this MasterSkills model)
        {
            return new MasterSkillsViewModels
            {

                IsSoftSkill = model.IsSoftSkill,
                IsKnowledge = model.IsKnowledge,
                Percentage = model.Percentage,
                Name = model.Name,
                Id = model.Id,
                IsActive = model.IsActive,

            };
        }
        public static List<MasterSkillsViewModels> ToViewModelList(this List<MasterSkills> model)
        {
            return model.Select(x => x.ToViewModel()).ToList();

        }
        public static List<MasterSkills> ToModelList(this List<MasterSkillsViewModels> model)
        {
            return model.Select(x => x.ToModel()).ToList();

        }
    }
}



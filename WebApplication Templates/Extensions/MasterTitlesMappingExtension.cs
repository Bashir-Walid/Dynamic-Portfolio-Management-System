using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.Runtime.CompilerServices;
using WebApplication_Templates.Models;
using WebApplication_Templates.ViewModels;

namespace WebApplication_Templates.Extensions
{
    public static class MasterTitlesMappingExtension
    {
        public static MasterTitles ToModel(this MasterTitlesViewModels model)
        {
            return new MasterTitles
            {
                IsActive = model.IsActive,
               Title=model.Title,
                Id = model.Id,
                Keyword=model.Keyword,
               

            };
        }
        public static MasterTitlesViewModels ToViewModel(this MasterTitles model)
        {
            return new MasterTitlesViewModels
            {
                IsActive = model.IsActive,
                Title = model.Title,
                Id = model.Id,
                Keyword = model.Keyword,
            };
        }
        public static List<MasterTitlesViewModels> ToViewModelList(this List<MasterTitles> model)
        {
            return model.Select(x => x.ToViewModel()).ToList();

        }
        public static List<MasterTitles> ToModelList(this List<MasterTitlesViewModels> model)
        {
            return model.Select(x => x.ToModel()).ToList();

        }
    }
}

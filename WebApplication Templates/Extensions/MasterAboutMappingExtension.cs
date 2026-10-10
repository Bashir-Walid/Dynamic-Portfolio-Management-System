using WebApplication_Templates.Models;
using WebApplication_Templates.ViewModels;

namespace WebApplication_Templates.Extensions
{
    public static class MasterAboutMappingExtensions
    {
        public static MasterAbout ToModel(this MasterAboutViewModels model)
        {
            return new MasterAbout
            {
                
                IsActive = model.IsActive,
                Name = model.Name,
                Id = model.Id,
                Address= model.Address,
                Country= model.Country,
                DateOfBarth = model.DateOfBarth.GetValueOrDefault(),
                Desc = model.Desc,
                Email= model.Email,
                CVUrl= model.CVUrl,
                ImageURL= model.ImageURL,
                PhoneNumber= model.PhoneNumber,
                

            };
        }
        public static MasterAboutViewModels ToViewModel(this MasterAbout model)
        {
            return new MasterAboutViewModels
            {
                IsActive = model.IsActive,
                Name = model.Name,
                Id = model.Id,
                Address = model.Address,
                Country = model.Country,
                DateOfBarth = model.DateOfBarth,
                Desc = model.Desc,
                Email = model.Email,
                CVUrl = model.CVUrl,
                ImageURL = model.ImageURL,
                PhoneNumber = model.PhoneNumber,
                Age=DateTime.Now.Year - model.DateOfBarth.Year

            };
        }
        public static List<MasterAboutViewModels> ToViewModelList(this List<MasterAbout> model)
        {
            return model.Select(x => x.ToViewModel()).ToList();

        }
        public static List<MasterAbout> ToModelList(this List<MasterAboutViewModels> model)
        {
            return model.Select(x => x.ToModel()).ToList();

        }
    }
}



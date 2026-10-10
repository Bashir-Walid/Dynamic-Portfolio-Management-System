using WebApplication_Templates.Models;
using WebApplication_Templates.ViewModels;

namespace WebApplication_Templates.Extensions
{
    public static class MasterTestimonialsMappingExtension
    {
        public static MasterTestimonials ToModel(this MasterTestimonialsViewModels model)
        {
            return new MasterTestimonials
            {

                Title = model.Title,

                IsActive = model.IsActive,
                Name = model.Name,
                Id = model.Id,
                Desc = model.Desc,
                ImageURL = model.ImageURL,


            };
        }
        public static MasterTestimonialsViewModels ToViewModel(this MasterTestimonials model)
        {
            return new MasterTestimonialsViewModels
            {
                IsActive = model.IsActive,
                Name = model.Name,
                Id = model.Id,
                Desc = model.Desc,
                ImageURL = model.ImageURL,
                Title = model.Title,

            };
        }
        public static List<MasterTestimonialsViewModels> ToViewModelList(this List<MasterTestimonials> model)
        {
            return model.Select(x => x.ToViewModel()).ToList();

        }
        public static List<MasterTestimonials> ToModelList(this List<MasterTestimonialsViewModels> model)
        {
            return model.Select(x => x.ToModel()).ToList();

        }
    }
}
    


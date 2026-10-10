using WebApplication_Templates.Models;
using WebApplication_Templates.ViewModels;

namespace WebApplication_Templates.Extensions
{
    public static class MasterClientsMappingExtension
    {
        public static MasterClients ToModel(this MasterClientsViewModels model)
        {
            return new MasterClients
            {


                IsActive = model.IsActive,
                Id = model.Id,
                ImageURL = model.ImageURL,


            };
        }
        public static MasterClientsViewModels ToViewModel(this MasterClients model)
        {
            return new MasterClientsViewModels
            {
                IsActive = model.IsActive,
                Id = model.Id,
                ImageURL = model.ImageURL,

            };
        }
        public static List<MasterClientsViewModels> ToViewModelList(this List<MasterClients> model)
        {
            return model.Select(x => x.ToViewModel()).ToList();

        }
        public static List<MasterClients> ToModelList(this List<MasterClientsViewModels> model)
        {
            return model.Select(x => x.ToModel()).ToList();

        }
    }
}
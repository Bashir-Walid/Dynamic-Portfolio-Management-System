using WebApplication_Templates.Models;
using WebApplication_Templates.ViewModels;

namespace WebApplication_Templates.Extensions
{
    public static class MasterCertificatesMappingExtensions
    {
        public static MasterCertificates ToModel(this MasterCertificatesViewModels model)
        {
            return new MasterCertificates
            {
                
                IsActive = model.IsActive,
                MembershipId = model.MembershipId,
                Id = model.Id,
                Title = model.Title,
                Date = model.Date.GetValueOrDefault(),
                ImageURL = model.ImageURL,
                

            };
        }
        public static MasterCertificatesViewModels ToViewModel(this MasterCertificates model)
        {
            return new MasterCertificatesViewModels
            {
                IsActive = model.IsActive,
                MembershipId = model.MembershipId,
                Id = model.Id,
                Title = model.Title,
                Date = model.Date,
                ImageURL = model.ImageURL,

            };
        }
        public static List<MasterCertificatesViewModels> ToViewModelList(this List<MasterCertificates> model)
        {
            return model.Select(x => x.ToViewModel()).ToList();

        }
        public static List<MasterCertificates> ToModelList(this List<MasterCertificatesViewModels> model)
        {
            return model.Select(x => x.ToModel()).ToList();

        }
    }
}



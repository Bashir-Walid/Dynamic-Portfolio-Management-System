
using Microsoft.AspNetCore.Http;
using WebApplication_Templates.Helpers.File;

namespace WebApplication_Templates.ViewModels
{
    using Microsoft.AspNetCore.Http;
    public class MasterAboutViewModels
    {
        public int Id { get; set; }

        public string Name { get; set; }
        public string? ImageURL { get; set; }
        public IFormFile? ImageFile { get; set; }
        public string? CVUrl { get; set; }
        public IFormFile? CVFile { get; set; }
        public string? Desc { get; set; }
        public DateTime? DateOfBarth { get; set; }
        public string Country { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public int Age { get; set; }
        public bool IsActive { get; set; }

     
    }
}

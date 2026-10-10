using System.Numerics;
using Microsoft.AspNetCore.Http;
namespace WebApplication_Templates.Models
    //Table About: Id/ ImageURL / Name / CV / Desc / DOB / Country / Address / Email / Phone number / Age

{
    public class MasterAbout :BaseEntity
    {
        public string Name { get; set; }
        public string ImageURL { get; set; }
        public string CVUrl { get; set; }
        public string Desc { get; set; }
        public DateTime DateOfBarth { get; set; }
        public string Country { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string PhoneNumber  { get; set; }

    }
}

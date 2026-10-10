using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace WebApplication_Templates.Models
{
    //Table Testimonials : Id / Name / Desc / Image / Title

    public class MasterTestimonials :BaseEntity
    {
        public string Name { get; set; }
        public string Desc { get; set; }
        public string ImageURL { get; set; }
        public string Title { get; set; }
    }
}

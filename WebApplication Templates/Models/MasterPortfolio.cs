using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace WebApplication_Templates.Models
{
    //Table PlanItems : Id/ Desc / PlanId

    public class MasterPortfolio : BaseEntity
    {
        public string Title { get; set; }
        public int CategoryId { get; set; }
        public MasterCategory Category { get; set; }
        public string ThumbnailImg { get; set; }
        public string ViewImg { get; set; }

    }
}

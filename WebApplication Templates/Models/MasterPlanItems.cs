using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace WebApplication_Templates.Models
{
    //Table PlanItems : Id/ Desc / PlanId

    public class MasterPlanItems:BaseEntity
    {
        public string Desc { get; set; }
        public int PlanId { get; set; }
        public MasterPlans Plan { get; set; }

    }
}

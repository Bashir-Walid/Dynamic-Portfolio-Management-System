
namespace WebApplication_Templates.ViewModels
{
    public class MasterPlanItemsViewModels
    {
        public string Desc { get; set; }
        public int PlanId { get; set; }
        public int Id { get; set; }
        public string Name { get; set; }

        public string Price { get; set; }
        public string PricePeriod { get; set; }
        public bool IsSuggested { get; set; }
        public bool IsActive { get; set; }
    }
}

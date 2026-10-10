namespace WebApplication_Templates.ViewModels
{
    public class MasterPlanItemsFullViewModels
    {
        public string Desc { get; set; }
        public int PlanId { get; set; }
        public int Id { get; set; }
        public string Name { get; set; }

        public string Price { get; set; }
        public string PricePeriod { get; set; }
        public bool IsSuggested { get; set; }
        public bool IsActive { get; set; }
        public bool IsDelete { get; set; }
        public bool IsDeleted { get; internal set; }
        public List<MasterPlanItemsViewModels> list { get; set; }
        public List<MasterPlansViewModels> listet { get; set; }

        public int DeleteId { get; set; }
    }
}

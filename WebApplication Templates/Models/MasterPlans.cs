namespace WebApplication_Templates.Models
{
     //Id / Name / Price / PricePeriod / PricePeriod

    public class MasterPlans :BaseEntity
    {
        public string Name { get; set; }

        public string Price { get; set; }
        public string PricePeriod { get; set; }
        public bool IsSuggested { get; set; }

    }
}

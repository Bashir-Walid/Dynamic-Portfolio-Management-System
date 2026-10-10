namespace WebApplication_Templates.Models
    //Table Positions: Id / Name / IsPrimary(for Position)

{
    public class MasterPositions:BaseEntity
    {
        public string Name { get; set; }
        public bool IsPrimary { get; set; }
    }
}

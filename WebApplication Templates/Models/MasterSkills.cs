namespace WebApplication_Templates.Models
{
    public class MasterSkills :BaseEntity
    {
        public string Percentage { get; set; }
        public string Name { get; set; }
        public bool IsSoftSkill { get; set; }
        public bool IsKnowledge { get; set; }
    }
}

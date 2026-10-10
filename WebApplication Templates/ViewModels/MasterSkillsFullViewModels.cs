namespace WebApplication_Templates.ViewModels
{
    public class MasterSkillsFullViewModels
    {
        public string Percentage { get; set; }
        public string Name { get; set; }
        public bool IsSoftSkill { get; set; }
        public bool IsKnowledge { get; set; }
        public int Id { get; set; }
        public bool IsActive { get; set; }
        public List<MasterSkillsViewModels> list { get; set; }
        public bool IsDelete { get; set; }
        public bool IsDeleted { get; set; }
        public int DeleteId { get; set; }
    }
}

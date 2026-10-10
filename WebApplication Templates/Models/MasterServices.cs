using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace WebApplication_Templates.Models
{
    //Table Services : Id / Icon / Name / Desc

    public class MasterServices :BaseEntity
    {
        public string Icon { get; set; }
        public string Name { get; set; }
        public string Desc { get; set; }
    }
}

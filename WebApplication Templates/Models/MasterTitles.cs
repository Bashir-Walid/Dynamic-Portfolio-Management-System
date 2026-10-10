using static Microsoft.Extensions.Logging.EventSource.LoggingEventSource;

namespace WebApplication_Templates.Models
    //Table Titles : Id / Title / Keyword

{
    public class MasterTitles :BaseEntity
    {
        public string Title { get; set; }
        public string Keyword { get; set; }
    }
}

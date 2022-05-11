using WebAPI.Digital.Tools;

namespace WebAPI.Digital.API2.Model
{
    public class Relations
    {
        public int Id { get; set; }
        public string CUserId { get; set; }
        public DateTime CDate { get; set; }
        public bool IsDeleted { get; set; } = false;
        public string Name { get; set; }
        public SegmentClient Segment { get; set; }

        public string DigitalId { get; set; }
        public string Scope { get; set; }

        public DateTime? UDate { get; set; }

        public string? UUserId { get; set; }
    }
}

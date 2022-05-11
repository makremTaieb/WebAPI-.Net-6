using WebAPI.Digital.Domain;
using WebAPI.Digital.Tools;

namespace WebAPI.Digital.API2.Domain
{
    public class Relations : BaseEntity
    {
      
       
        public string Name { get; set; }
        public SegmentClient Segment { get; set; }
        public string Scope { get; set; }

    }
}

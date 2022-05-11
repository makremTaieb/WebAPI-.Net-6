using Digital.Core;
using Digital.Core.Model;
using System.ComponentModel.DataAnnotations.Schema;

namespace Digital.BackOffice.Model
{
    public class Relation : BaseEntity<int>
    {
        public string DigitalId { get; set; }

        public string Name { get; set; }

        public int Segment { get; set; }

        [ForeignKey("RelationId")]
        public ICollection<RelationTiers> RTiers1 { get; set; }

        public void Update(Relation newObj)
        {
            if(newObj != null)
            {
                Name= newObj.Name;
                Segment = newObj.Segment;
            }
        }


    }
}

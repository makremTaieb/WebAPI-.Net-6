using Digital.BackOffice.Model;
using Digital.Core.Model;
using System.ComponentModel.DataAnnotations.Schema;

namespace Digital.BackOffice.Model
{
    [Table("RT")]
    public class RelationTiers : BaseEntity<int>
    {
        public int? RelationId { get; set; }
        public Relation Relation { get; set; }

        public int? TierId { get; set; }
        public Tier Tier { get; set; }
    }
}

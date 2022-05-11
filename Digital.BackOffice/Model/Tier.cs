using Digital.Core;
using Digital.Core.Model;

namespace Digital.BackOffice.Model
{
    public class Tier : BaseEntity<int>
    {
        public string DigitalId { get; set; }

        public int Scope { get; set; }

        public string Name { get; set; }

        public string Domain { get; set; }

        public ICollection<Account> Accounts { get; set; }

        public List<RelationTiers> RTiers3 { get; set; }

    }
}

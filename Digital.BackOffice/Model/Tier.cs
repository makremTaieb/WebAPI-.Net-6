using Digital.Core;
using Digital.Core.Model;

namespace Digital.BackOffice.Model
{
    public class Tier : BaseEntity<int>
    {
        public Tier()
        {
            this.Relations = new HashSet<Relation>(); 
        }
        public string DigitalId { get; set; }

        public int Scope { get; set; }

        public string Name { get; set; }

        public string Domain { get; set; }

        public ICollection<Account> Accounts { get; set; }

        public virtual ICollection<Relation> Relations { get; set; }

        public void Update(Tier newObj)
        {
            if (newObj != null)
            {
                Scope = newObj.Scope;
                Domain = newObj.Domain;
                UDate = newObj.UDate;  
                UUSer = newObj.UUSer;
            }
        }

    }
}

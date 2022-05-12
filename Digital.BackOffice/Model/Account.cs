using Digital.Core;
using Digital.Core.Model;

namespace Digital.BackOffice.Model
{
    public class Account : BaseEntity<int>
    {
        public string AccountNumber { get; set; }

        public string RIB { get; set; }
    }
}

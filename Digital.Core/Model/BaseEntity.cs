using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Digital.Core.Model
{
    public class BaseEntity<TKey>
    {
        public TKey Id { get; set; }

        public DateTime CDate { get; set; } = DateTime.Now;

        public string CUser { get; set; } = string.Empty;

        public DateTime? UDate { get; set; }

        public string UUSer { get; set; } = string.Empty;

        public bool IsDeleted { get; set; }
    }
}

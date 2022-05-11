using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebAPI.Digital.Domain
{
    public class BaseEntity
    {
        public int Id { get; set; }
        public string CUserId { get; set; }
        public DateTime CDate { get; set; } = DateTime.Now;
        public string DigitalId { get; set; }
        public bool IsDeleted { get; set; } = false;

        public DateTime? UDate { get; set; }

        public string? UUserId { get; set; }

    }
}

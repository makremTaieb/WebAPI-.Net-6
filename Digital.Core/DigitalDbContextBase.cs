using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Digital.Core
{
    public abstract class DigitalDbContextBase : DbContext
    {
        public DigitalDbContextBase(DbContextOptions option):base(option)
        {

        }
    }
}

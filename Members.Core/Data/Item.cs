using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Members.Core.Data
{
    public abstract class Item
    {
        public int Id { get; set; }
        public bool Zombie { get; set; } = false;
    }
}

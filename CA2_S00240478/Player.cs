using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA2_S00240478
{
    internal class Player
    {
        public string Name { get; set; }
        public string ResultRecord { get; set; }

        public override string ToString()
        {
            return $"{Name} - {ResultRecord}";
        }
    }
}

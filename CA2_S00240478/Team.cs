﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace CA2_S00240478
{
    internal class Team
    {
        public string Name { get; set; }
        public List<Player> Players { get; set; }

        public override string ToString()
        {
            return $"{Name}";
        }
    }
}

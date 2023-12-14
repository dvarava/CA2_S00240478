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

        public int Points
        {
            get
            {
                int points = 0;

                foreach (char result in ResultRecord)
                {
                    if (result == 'W')
                    {
                        points += 3;
                    }
                    else if (result == 'D')
                    {
                        points += 1;
                    }
                }
                return points;
            }
        }

        public override string ToString()
        {
            return $"{Name} - {ResultRecord} - {Points}";
        }
    }
}

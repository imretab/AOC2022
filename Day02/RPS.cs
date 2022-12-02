using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_02
{
    class RPS
    {
        public char YourChoice { get; set; }
        public char ElfChoice { get; set; }
        public RPS(char ec, char yc)
        {
            YourChoice = yc;
            ElfChoice = ec;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_04
{
    class Ranges
    {
        public int Start { get; set; }
        public int End { get; set; }
        public Ranges(int r1, int r2)
        {
            Start = r1;
            End = r2;
        }
    }
}

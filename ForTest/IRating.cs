using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForTest
{
    internal interface IRating
    {
        public double Rating { get; }

        public Dictionary<string, int> Grades { get; set; }

        public void CalculateRating();
    }
}

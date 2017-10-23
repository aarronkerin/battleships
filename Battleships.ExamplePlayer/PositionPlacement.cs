using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battleships.ExamplePlayer
{
    class PositionPlacement
    {
        public class ShipPositionPlacement
        {
            public char StartRow { get; set; }
            public int StartCol { get; set; }
            public char EndRow { get; set; }
            public int EndCol { get; set; }
        }
    }
}

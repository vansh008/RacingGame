using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RacingGame
{
    //Simple stats on all three betters
    class Jerry : Punter
    {
        public Jerry()
        {
            name = "Jerry";
            cash = 50;
        }
    }
    class Al : Punter
    {
        public Al()
        {
            name = "Al";
            cash = 50;
        }
    }
    class Tom : Punter
    {
        public Tom()
        {
            name = "Tom";
            cash = 50;
        }
    }
}

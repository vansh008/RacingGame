using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RacingGame
{
    public class Race
    {
        public RadioButton myRadioButton { get; set; }
        public Boolean JerryBet { get; set; }
        public Boolean AlBet { get; set; }
        public Boolean TomBet { get; set; }
        public int JerryAmount { get; set; }
        public int AlAmount { get; set; }
        public int TomAmount { get; set; }
        public int JerryThing { get; set; }
        public int AlThing { get; set; }
        public int TomThing { get; set; }
        public int JerryCash { get; set; }
        public int AlCash { get; set; }
        public int TomCash { get; set; }
        public int TrackLength { get; set; }
        public int Winner { get; set; }
    }
}
 
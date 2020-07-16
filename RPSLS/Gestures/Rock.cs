using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    class Rock : Gesture
    {
        public Rock()
        {
            name = "Rock";
        }

        public override void Challenge(Rock gesture, string[] winMessages)
        {
            
        }

        public override void Challenge(Spock gesture, string[] winMessages)
        {
            throw new NotImplementedException();
        }

        public override void Challenge(Paper gesture, string[] winMessages)
        {
            throw new NotImplementedException();
        }

        public override void Challenge(Lizard gesture, string[] winMessages)
        {
            throw new NotImplementedException();
        }

        public override void Challenge(Scissors gesture, string[] winMessages)
        {
            throw new NotImplementedException();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    class Lizard : Gesture
    {
        public Lizard()
        {
            name = "Lizard";
            number = 9;
        }

        public override bool Challenge(Gesture paper)
        {
            throw new NotImplementedException();
        }
    }
}

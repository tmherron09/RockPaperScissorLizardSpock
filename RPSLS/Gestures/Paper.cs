using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    class Paper : Gesture
    {
        public Paper()
        {
            name = "Paper";
            number = 8;
        }

        public override bool Challenge(Gesture paper)
        {
            throw new NotImplementedException();
        }
    }
}

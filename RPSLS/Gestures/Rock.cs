using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
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
            number = 6;
            verbs = new string[] { "smashes", "crushes" };
        }

        
    }
}

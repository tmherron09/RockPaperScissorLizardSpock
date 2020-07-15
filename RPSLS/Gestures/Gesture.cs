using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    abstract class Gesture
    {
        public string name;  // May not need if I overload ToString.

        public Gesture()
        {

        }

        public virtual bool CanWin(Gesture gesture)
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            return name;
        }
    }
}

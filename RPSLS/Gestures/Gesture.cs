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

        public void Challenge(Gesture gesture, string[] winMessages)
        {
            throw new NotImplementedException;
        }
        public abstract void Challenge(Rock gesture, string[] winMessages);
        public abstract void Challenge(Spock gesture, string[] winMessages);
        public abstract void Challenge(Paper gesture, string[] winMessages);
        public abstract void Challenge(Lizard gesture, string[] winMessages);
        public abstract void Challenge(Scissors gesture, string[] winMessages);
        
        


        public override string ToString()
        {
            return name;
        }
    }
}

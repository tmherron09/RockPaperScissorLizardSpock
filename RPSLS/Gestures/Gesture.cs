using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    abstract class Gesture
    {
        public string name;  // May not need if I overload ToString.
        public int number;
        string[] verbs;
        public Gesture()
        {
            
        }

        public string Challenge(Gesture gesture)
        {
            string msg = $"{name} Ties {gesture.name}";
            for (int i = 1; i < 3; i++)
            {
                if (((number - i) % 5) == gesture.number % 5)
                {
                    msg = $"{name} {verbs[i-1]} {gesture.name}!";
                }
                if (((number + i) % 5) == gesture.number % 5)
                {
                    msg = $"{gesture.name} {verbs[2 - i]} {name}!";
                }
            }
            return msg;
        }
        


        public override string ToString()
        {
            return name;
        }
    }
}

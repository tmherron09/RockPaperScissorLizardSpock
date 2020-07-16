using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    class Computer : Player
    {
        public Random rng;
        public Computer()
        {
            isHuman = false;
            playerType = "COM";
            rng = new Random();
        }

        public override void ChooseGesture(List<Gesture> gestures)
        {
            gesture = gestures[rng.Next(0, 6)];
        }

        public override void ChooseGesture(List<Gesture> gestures, string playerType)
        {
            gesture = gestures[rng.Next(0, 6)];
        }

        public override void ChooseGesture(List<Gesture> gestures, string playerType, int startLeft, int startTop)
        {
            gesture = gestures[rng.Next(0, 6)];
        }

        
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    abstract class Player
    {
        public int score;
        public string playerType;
        public bool isHuman;
        public List<Gesture> gestures;

        public Player()
        {
            score = 0;
            gestures = new List<Gesture>()
            {
                new Rock(),
                new Paper(),
                new Scissors(),
                new Lizard(),
                new Spock()
            };
        }

        public override string ToString()
        {
            return playerType;
        }

        public void ChooseGesture()
        {
            string gestureChoice = GetGestureChoice();
            DisplayHelper.GetUserInput(1, gestures.Count, gestureChoice);
        }

        public string GetGestureChoice()
        {

        }
    }
}

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
        public Gesture gestureChoice;

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

        public virtual void ChooseGesture()
        {
            string gestureChoiceMessage = GetGestureChoiceMessage();
            int playerInput = DisplayHelper.GetUserInput(1, gestures.Count, gestureChoiceMessage, 10, 7);
            gestureChoice = gestures[playerInput - 1];
        }

        public string GetGestureChoiceMessage()
        {
            string choices = "";
            choices += $"Choose your hand:\n";
            for(int i = 0; i < gestures.Count; i++)
            {
                choices += $"{i + 1}) {gestures[i]}\n";
            }
            return choices;
        }
    }
}

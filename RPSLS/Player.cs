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
        public string winMessage;
        
        

        public Player()
        {
            score = 0;
        }

        public override string ToString()
        {
            return playerType;
        }

        public virtual int ChooseGesture(List<Gesture> gestures)
        {
            string gestureChoiceMessage = GetGestureChoiceMessage();
            return DisplayHelper.GetUserInput(1, gestures.Count, gestureChoiceMessage, 15, 7);
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

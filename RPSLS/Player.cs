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
        public Gesture gesture;
        
        

        public Player()
        {
            score = 0;

        }

        public override string ToString()
        {
            return playerType;
        }

        public virtual Gesture ChooseGesture(List<dynamic> gestures)
        {
            string gestureChoiceMessage = GetGestureChoiceMessage(gestures);
            int userInput = DisplayHelper.GetUserInput(1, gestures.Count, gestureChoiceMessage, 15, 7);
            return gestures[userInput - 1];
        }

        public virtual void Test()
        {
            Console.WriteLine($"{ playerType}");
        }

        public string GetGestureChoiceMessage(List<dynamic> gestures)
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

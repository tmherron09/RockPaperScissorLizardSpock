﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    class Human : Player
    {
        public Human(int playerNumber) : base()
        {
            isHuman = true;
            playerType = $"Player {playerNumber}";
        }

        
        public override void ChooseGesture(List<Gesture> gestures)
        {
            string gestureChoiceMessage = GetGestureChoiceMessage(gestures);
            int userInput = DisplayHelper.GetUserInput(1, gestures.Count, gestureChoiceMessage, 15, 7);
            gesture = gestures[userInput - 1];
        }
        public override void ChooseGesture(List<Gesture> gestures, string playerType)
        {
            string gestureChoiceMessage = GetGestureChoiceMessage(gestures, playerType);
            int userInput = DisplayHelper.GetUserInputHidden(1, gestures.Count, gestureChoiceMessage, 15, 7);
            gesture = gestures[userInput - 1];
        }
        public override void ChooseGesture(List<Gesture> gestures, string playerType, int startLeft, int startTop)
        {
            string gestureChoiceMessage = GetGestureChoiceMessage(gestures, playerType);
            int userInput = DisplayHelper.GetUserInputHidden(1, gestures.Count, gestureChoiceMessage, startLeft, startTop);
            gesture = gestures[userInput - 1];
        }

        public string GetGestureChoiceMessage(List<Gesture> gestures)
        {
            string choices = "";
            choices += $"Choose your hand:\n";
            for (int i = 0; i < gestures.Count; i++)
            {
                choices += $"{i + 1}) {gestures[i]}\n";
            }
            return choices;
        }
        public string GetGestureChoiceMessage(List<Gesture> gestures, string playerType)
        {
            string choices = "";
            choices += $"Choose your hand {playerType}:\n";
            for (int i = 0; i < gestures.Count; i++)
            {
                choices += $"{i + 1}) {gestures[i]}\n";
            }
            return choices;
        }
    }
}

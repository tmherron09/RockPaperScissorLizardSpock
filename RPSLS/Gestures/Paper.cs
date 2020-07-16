﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    class Paper : Gesture
    {
        public Paper()
        {
            name = "Paper";
            number = 8;
            verbs = new string[] { "disproves", "covers" };
        }
        // Second method using set Switch statements.
        public override string ChallengeSwitch(Gesture gesture, List<Player> players)
        {
            string msg = "";
            switch (gesture.number)
            {
                case 8:
                    msg = $"{name} Ties {gesture.name}";
                    break;
                case 9:
                    msg = $"{gesture.name} {gesture.verbs[0]} {name}!\n\n{players[1].playerType} Wins the Round!";
                    players[1].score++;
                    break;
                case 10:
                    msg = $"{gesture.name} {gesture.verbs[1]} {name}!\n\n{players[1].playerType} Wins the Round!";
                    players[1].score++;
                    break;
                case 6:
                    msg = $"{name} {verbs[1]} {gesture.name}!\n\n{players[0].playerType} Wins the Round!";
                    players[0].score++;
                    break;
                case 7:
                    msg = $"{name} {verbs[0]} {gesture.name}!\n\n{players[0].playerType} Wins the Round!";
                    players[0].score++;
                    break;
            }
            return msg;
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    abstract class Gesture
    {
        public string name;
        public int number; // Clock Arithmetic Position 
        public string[] verbs;
        public Gesture()
        {
            
        }
        /// <summary>
        /// Gets the results of a Hand Toss.
        /// Called off Player 1 or First Seat.
        /// </summary>
        /// <param name="gesture">The Player 2/Second seat Gesture</param>
        /// <param name="players">List of Players to set score after evaluation.</param>
        /// <returns></returns>
        public string Challenge(Gesture gesture, List<Player> players)
        {
            string msg = $"{name} Ties {gesture.name}";
            for (int i = 1; i < 3; i++)
            {
                if (((number - i) % 5) == gesture.number % 5)
                {
                    msg = $"\t\t{name} {verbs[i-1]} {gesture.name}!\n\n{players[0].playerType} Wins the Round!";
                    players[0].score++;
                }
                if (((number + i) % 5) == gesture.number % 5)
                {
                    msg = $"\t\t{gesture.name} {gesture.verbs[i - 1]} {name}!\n\n{players[1].playerType} Wins the Round!";
                    players[1].score++;
                }
            }
            return msg;
        }
        // Second method using set Switch statements.
        public abstract string ChallengeSwitch(Gesture gesture, List<Player> players);
        // WIP: Third method using Switch and Modulos/Clock arithmetic
        public string ChallengeSwitchModuls(Gesture gesture, List<Player> players)
        {
            string msg = "";
            switch (gesture.number % 5)
            {
                case 0:
                    msg = $"{name} Ties {gesture.name}";
                    break;
                case 1:
                    msg = $"{gesture.name} {gesture.verbs[0]} {name}!\n\n{players[1].playerType} Wins the Round!";
                    players[1].score++;
                    break;
                case 2:
                    msg = $"{gesture.name} {gesture.verbs[1]} {name}!\n\n{players[1].playerType} Wins the Round!";
                    players[1].score++;
                    break;
                case 3:
                    msg = $"{name} {verbs[1]} {gesture.name}!\n\n{players[0].playerType} Wins the Round!";
                    players[0].score++;
                    break;
                case 4:
                    msg = $"{name} {verbs[0]} {gesture.name}!\n\n{players[0].playerType} Wins the Round!";
                    players[0].score++;
                    break;
            }
            return msg;
        }
    
        
    }
}

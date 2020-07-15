using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    class Game
    {
        private int numberOfRounds;
        private int currentRound;

        public Game()
        {
            InitializeGame();
        }
        private void InitializeGame()
        {
            currentRound = 1;
            numberOfRounds = 3; // Placeholder initialization
        }
        public void Run()
        {
            // Initialization and Reset if Playing again.
            // Display Game information
            // Choose Number of Players
            // PlayGame()
            // PlayAgain()
        }

        public void PlayGame()
        {
            bool hasWinner = false;
            while (!hasWinner) // Placeholder until logic
            {
                // Display Turn Info and Score
                // Display Choices
                // Get User Input
                // Display Both Hands and Declare winner
                // Add to scores.
            }
            // Display Winner Info!
        }
    }
}

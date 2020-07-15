using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    class Game
    {
        private List<Player> players;
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
            players = new List<Player>() { null, new Computer() };
        }
        public void Run()
        {
            // Initialization and Reset if Playing again.
            // Display Game information
            ChooseNumberOfPlayers();
            PlayGame();
            // PlayAgain()
        }

        private void ChooseNumberOfPlayers()
        {
            //Console.Write("Please select the number of players (1/2): ");
            int selection = GetUserInput(1, 2, "Please select the number of players(1 / 2): ");
            for(int i = 0; i < selection; i++)
            {
                players[i] = new Human(i+1);
            }
            //Console.ReadLine();
        }



        public void PlayGame()
        {
            while (currentRound <= numberOfRounds) // Placeholder until logic
            {
                // Display Round Info and Score
                DisplayRoundInformation();
                // Display Choices

                // Get User Input
                // Display Both Hands and Declare winner
                // Add to scores.
                Console.ReadKey();
                currentRound++;
            }
            // Display Winner Info!
        }

        

        private int GetUserInput(int lowLimit, int upperLimit, string choiceMessage)
        {
            bool valid = false;
            int userInput = 0;
            string invalidMessage = "";
            do
            {
                Console.WriteLine(invalidMessage + choiceMessage);
                valid = Int32.TryParse(Console.ReadLine(), out userInput);
                if (userInput < lowLimit || userInput > upperLimit)
                {

                    ClearLinesOfScreen(0, 5);
                    invalidMessage = "Invalid Input: Please try again.\n";
                    valid = false;
                }
            } while (!valid);
            return userInput;
        }
        private void ClearLinesOfScreen(int lineStart, int numberOfLines)
        {
            string blankLine = new string(' ', Console.WindowWidth);
            for (int i = lineStart; i < numberOfLines; i++)
            {
                Console.SetCursorPosition(0, i);
                Console.WriteLine(blankLine);
            }
            Console.SetCursorPosition(0, 0);
        }

        private void DisplayRoundInformation()
        {
            ClearLinesOfScreen(0, 20);
            string msg = $"Round {currentRound} : {players[0]} Score: {players[0].score} | {players[1]} Score: {players[1].score}";
            int startWriteLocation = (Console.WindowWidth - msg.Length) / 2;
            Console.SetCursorPosition(startWriteLocation, 5);
            Console.Write(msg);
        }
    }
}

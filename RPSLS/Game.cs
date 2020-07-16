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
        public List<Gesture> gestures;


        public Game()
        {
            

            gestures = new List<Gesture>()
            {
                new Rock(),
                new Spock(),
                new Paper(),
                new Lizard(),
                new Scissors()

            };

        }
        private void InitializeGame()
        {
            Console.Clear();
            currentRound = 1;
            numberOfRounds = 3; // Placeholder initialization
            players = new List<Player>() { null, new Computer() };
        }
        public void Run()
        {
            do
            {
                InitializeGame();
                // Display Game information
                ChooseNumberOfPlayers();
                PlayGame();
            } while (PlayAgain());
        }

        private void ChooseNumberOfPlayers()
        {
            string choice = "Please select the number of players(1 / 2): ";
            int startWriteLocation = (Console.WindowWidth - choice.Length) / 2;
            int selection = DisplayHelper.GetUserInput(1, 2, choice, startWriteLocation, 5);
            for (int i = 0; i < selection; i++)
            {
                players[i] = new Human(i + 1);
            }
            //Console.ReadLine();
        }



        public void PlayGame()
        {

            while (currentRound <= numberOfRounds || players[0].score == players[1].score) // Placeholder until logic
            {
                string result = "";
                // Display Round Info and Score
                DisplayRoundInformation();
                players[0].ChooseGesture(gestures, players[0].playerType, 30, 7);
                players[1].ChooseGesture(gestures, players[1].playerType, 60, 7);

                result = players[0].gesture.Challenge(players[1].gesture, players);
                DisplayRoundInformation(result);



                // Add to scores.
                Console.ReadKey();
                currentRound++;
            }
            // Display Winner Info!
            DisplayGameWinner();
        }

        private void DisplayGameWinner()
        {
            int winnerIndex;
            winnerIndex = players[0].score > players[1].score ? 0 : 1;
            string msg = $"\t{players[winnerIndex].playerType} is the Winner!\n\nPress any key to continue...";
            int startWriteLocation = (Console.WindowWidth - msg.Length) / 2;
            DisplayHelper.ClearLinesOfScreen(0, 40);
            DisplayHelper.WriteLiteral(msg, startWriteLocation, 8);
            Console.ReadKey();
        }

        private void DisplayRoundInformation()
        {
            DisplayHelper.ClearLinesOfScreen(0, 20);
            string msg = $"Round {currentRound} : {players[0]} Score: {players[0].score} | {players[1]} Score: {players[1].score}";
            int startWriteLocation = (Console.WindowWidth - msg.Length) / 2;
            Console.SetCursorPosition(startWriteLocation, 5);
            Console.Write(msg);
        }
        private void DisplayRoundInformation(string result)
        {
            DisplayHelper.ClearLinesOfScreen(0, 20);
            string msg = $"Round {currentRound} : {players[0]} Score: {players[0].score} | {players[1]} Score: {players[1].score}\n\n";
            int startWriteLocation = (Console.WindowWidth - msg.Length) / 2;
            DisplayHelper.WriteLiteral(msg + result, startWriteLocation + 1, 5);
        }
        public bool PlayAgain()
        {

            string msg = "Would you like to play again? (y/n): ";
            string userChoice;
            while (true)
            {
                Console.Clear();
                int startWriteLocation = (Console.WindowWidth - msg.Length) / 2;
                Console.SetCursorPosition(startWriteLocation, 5);
                Console.Write(msg);
                userChoice = Console.ReadLine().ToLower();
                if (userChoice == "y" || userChoice == "yes")
                {

                    return true;
                }
                else if (userChoice == "n" || userChoice == "no")
                {
                    return false;
                }
            }
        }
    }
}

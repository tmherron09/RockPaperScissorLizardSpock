using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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
        /// <summary>
        /// Initializes the game and resets values for a play again.
        /// </summary>
        private void InitializeGame()
        {
            Console.Clear();
            currentRound = 1;
            numberOfRounds = 3; // Placeholder initialization
            players = new List<Player>() { null, new Computer() };
        }
        /// <summary>
        /// Main Game Loop
        /// </summary>
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
        /// <summary>
        /// Asks the user how many players they would like to play.
        /// </summary>
        private void ChooseNumberOfPlayers()
        {
            string choice = "Please select the number of players(1 / 2): ";
            int startWriteLocation = (Console.WindowWidth - choice.Length) / 2;
            int selection = DisplayHelper.GetUserInput(1, 2, choice, startWriteLocation, 5);
            // If 1 player, loops once adding a human player 2 player, loops twice.
            for (int i = 0; i < selection; i++)
            {
                players[i] = new Human(i + 1); // i + 1 = Player "1" or Player "2"
            }
            //Console.ReadLine();
        }
        /// <summary>
        /// The main game logic loop. Ends after a set number of rounds and one player
        /// has a higher score.
        /// </summary>
        public void PlayGame()
        {
            while (currentRound <= numberOfRounds + 1 || players[0].score == players[1].score) // Placeholder until logic
            {
                string result = "";
                // Display Round Info and Score
                DisplayRoundInformation();
                players[0].ChooseGesture(gestures, players[0].playerType, 30, 7);
                players[1].ChooseGesture(gestures, players[1].playerType, 60, 7);

                //Count Down
                DisplayCountDown();

                result = players[0].gesture.Challenge(players[1].gesture, players);
                DisplayRoundInformation(result);



                // Add to scores.
                Console.ReadKey();
                currentRound++;
            }
            // Display Winner Info!
            DisplayGameWinner();
        }


        /// <summary>
        /// Displays the Winner.
        /// </summary>
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
        /// <summary>
        /// Displays the Round info prior to the toss.
        /// </summary>
        private void DisplayRoundInformation()
        {
            DisplayHelper.ClearLinesOfScreen(0, 20);
            string msg = $"Round {currentRound} : {players[0]} Score: {players[0].score} | {players[1]} Score: {players[1].score}";
            int startWriteLocation = (Console.WindowWidth - msg.Length) / 2;
            Console.SetCursorPosition(startWriteLocation, 5);
            Console.Write(msg);
        }
        /// <summary>
        /// Display the Round info after a toss.
        /// Shows the result of the toss.
        /// </summary>
        /// <param name="result">Result message recieved from Gesture Challange Method.</param>
        private void DisplayRoundInformation(string result)
        {
            DisplayHelper.ClearLinesOfScreen(0, 20);
            string msg = $"Round {currentRound} : {players[0]} Score: {players[0].score} | {players[1]} Score: {players[1].score}\n\n";
            int startWriteLocation = (Console.WindowWidth - msg.Length) / 2;
            DisplayHelper.WriteLiteral(msg + result, startWriteLocation + 1, 5);
        }
        /// <summary>
        /// Asks the player if they would like to play again.
        /// </summary>
        /// <returns>True: play again False: exit program</returns>
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
        /// <summary>
        /// Decorative method to display a countdown of 3...2...1....
        /// fake animation.
        /// </summary>
        private void DisplayCountDown()
        {
            int startWriteLocation = (Console.WindowWidth / 2) - 3;
            string dots = "";
            DisplayHelper.ClearLinesOfScreen(0, 20);
            for (int i = 3; i > 0; i--)
            {
                for (int j = 1; j < 5; j++)
                {
                    dots = new string('.', i);
                    Console.SetCursorPosition(startWriteLocation, 7);
                    Console.WriteLine(i + dots);
                    Thread.Sleep(200);
                }
                DisplayHelper.ClearLinesOfScreen();
            }
            Console.SetCursorPosition(startWriteLocation, 7);
            Console.WriteLine("GO!!!!!!");
            Thread.Sleep(500);
        }
    }
}

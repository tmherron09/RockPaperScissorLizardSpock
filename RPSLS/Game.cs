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
            InitializeGame();
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
            int selection = DisplayHelper.GetUserInput(1, 2, "Please select the number of players(1 / 2): ");
            for(int i = 0; i < selection; i++)
            {
                players[i] = new Human(i+1);
                
            }
            //Console.ReadLine();
        }



        public void PlayGame()
        {
            
            while (currentRound <= numberOfRounds || players[0].score == players[1].score) // Placeholder until logic
            {
                
                // Display Round Info and Score
                DisplayRoundInformation();
                
                int playerOneChoice = players[0].ChooseGesture(gestures);
                int playerTwoChoice = players[1].ChooseGesture(gestures);
                gestures[playerOneChoice].Challenge(gestures[playerTwoChoice], players);
                
                // Display Both Hands and Declare winner

                // Add to scores.
                Console.ReadKey();
                currentRound++;
            }
            // Display Winner Info!
        }

        

        
        

        private void DisplayRoundInformation()
        {
            DisplayHelper.ClearLinesOfScreen(0, 20);
            string msg = $"Round {currentRound} : {players[0]} Score: {players[0].score} | {players[1]} Score: {players[1].score}";
            int startWriteLocation = (Console.WindowWidth - msg.Length) / 2;
            Console.SetCursorPosition(startWriteLocation, 5);
            Console.Write(msg);
        }
    }
}

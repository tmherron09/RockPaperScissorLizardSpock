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
        public bool isHuman;
        public List<Gesture> gestures;

        public Player()
        {
            gestures = new List<Gesture>()
            {
                new Rock(),
                new Paper(),
                new Scissors(),
                new Lizard(),
                new Spock()
            };
        }
    }
}

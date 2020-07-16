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
        
        public Gesture gesture;
        
        

        public Player()
        {
            score = 0;

        }

        public override string ToString()
        {
            return playerType;
        }
        /// <summary>
        /// Call for Player to choose their gesture.
        /// </summary>
        /// <param name="gestures">List of gestures being played.</param>
        public abstract void ChooseGesture(List<Gesture> gestures);
        public abstract void ChooseGesture(List<Gesture> gestures, string playerType);
        public abstract void ChooseGesture(List<Gesture> gestures, string playerType, int startLeft, int startTop);

        public virtual void Test()
        {
            Console.WriteLine($"{ playerType}");
        }

        
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    class Program
    {
        static void Main(string[] args)
        {
            Game game = new Game();
            //game.Run();
            Gesture paper = new Paper();
            Console.WriteLine(paper);

            Console.ReadLine();
        }
    }
}

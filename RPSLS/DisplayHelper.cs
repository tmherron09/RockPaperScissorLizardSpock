using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    static class DisplayHelper
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="lowLimit"></param>
        /// <param name="upperLimit"></param>
        /// <param name="choiceMessage"></param>
        /// <returns></returns>
        public static int GetUserInput(int lowLimit, int upperLimit, string choiceMessage)
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
        public static int GetUserInput(int lowLimit, int upperLimit, string choiceMessage, int cursorStartLeft, int cursorStartTop)
        {
            bool valid = false;
            int userInput = 0;
            string invalidMessage = "";
            do
            {
                DisplayHelper.WriteLiteral((invalidMessage + choiceMessage),cursorStartLeft, cursorStartTop);
                valid = Int32.TryParse(Console.ReadLine(), out userInput);
                if (userInput < lowLimit || userInput > upperLimit)
                {
                    int numberOfLinesToErase = (Console.CursorTop - cursorStartTop) + 1;
                    ClearLinesOfScreen(cursorStartTop, numberOfLinesToErase);
                    invalidMessage = "Invalid Input: Please try again.\n";
                    valid = false;
                }
            } while (!valid);
            return userInput;
        }
        /// <summary>
        /// Clears lines in the console.
        /// Fills the lines with a string of ' ' the width of the window.
        /// </summary>
        /// <param name="lineStart">First line to clear</param>
        /// <param name="numberOfLines">Last line to clear</param>
        public static void ClearLinesOfScreen(int lineStart, int numberOfLines)
        {
            string blankLine = new string(' ', Console.WindowWidth);
            for (int i = lineStart; i < numberOfLines; i++)
            {
                Console.SetCursorPosition(0, i);
                Console.WriteLine(blankLine);
            }
            Console.SetCursorPosition(0, 0);
        }
        /// <summary>
        /// Clears lines in the console and Sets new Cursor start.
        /// Fills the lines with a string of ' ' the width of the window. 
        /// </summary>
        /// <param name="lineStart"></param>
        /// <param name="numberOfLines"></param>
        /// <param name="endLeft"></param>
        /// <param name="endTop"></param>
        public static void ClearLinesOfScreen(int lineStart, int numberOfLines, int endLeft, int endTop)
        {
            string blankLine = new string(' ', Console.WindowWidth);
            for (int i = lineStart; i < numberOfLines; i++)
            {
                Console.SetCursorPosition(0, i);
                Console.WriteLine(blankLine);
            }
            Console.SetCursorPosition(endLeft, endTop);
        }

        public static void WriteLiteral(string msg, int left, int top)
        {
            int pos = 0;
            msg = msg.Replace("\n", "¶");

            Console.SetCursorPosition(left, top);
            foreach (char letter in msg)
            {
                if (letter == '¶')
                {
                    top += 1;
                    Console.SetCursorPosition(left, top);
                }
                else
                {
                    Console.Write(msg[pos]);
                }
                pos++;
            }
        }
    }
}

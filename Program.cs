using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BonusLab1
{
    class Program
    {
        static void Main(string[] args)
        {
           
            string yesNo = "y";
            while (yesNo == "y" || yesNo == "Y")
            {
                int input = GetInput("How tall shall the tree be? ", 1, 20);
                for (int i = input; i > 0; i--)
                {
                    for (int j = 0; j < i; j++)
                    {
                        Console.Write(" ");
                    }
                    Console.Write(" ");

                    for (int k = i; k <= input; k++)
                    {
                        Console.Write("* ");
                    }
                    Console.WriteLine();   
                }
                yesNo = ynInput();
            }
        }
        public static int GetInput(string question, int bottomNum, int topNum)
        {
            bool validInput = false;
            int exitNum = 0;
            while (!validInput)
            {
                Console.Write(question);
                bool inp = int.TryParse(Console.ReadLine(), out exitNum);
                if (!inp || exitNum < bottomNum || exitNum > topNum)
                {
                    Console.WriteLine("That's not valid input!");
                }
                else
                {
                    validInput = true;
                }
            }
            return exitNum;
        }
        static string ynInput()
        {
            string input = "";
            bool invalid = true;
            while (invalid)
            {
                Console.WriteLine("");
                Console.WriteLine("Continue? (y/n): ");
                input = Console.ReadLine();
                if ((input == "y") || (input == "Y") || (input == "N") || (input == "n"))
                {
                    invalid = false;
                }
            }
            return input;
        }
    }
}

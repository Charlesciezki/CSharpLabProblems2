using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpProblems2
{
    class Program
    {
        static void Main(string[] args)
        {

            UserInputChecker userInputListChecker = new UserInputChecker();
            userInputListChecker.checkAgainstList();


            ShapeMaker shapes = new ShapeMaker(5);
            shapes.PrintOutForward();
            shapes.PrintOutUpSideDown();
            shapes.PrintOutBackWard();

            Console.WriteLine("Enter a number you'd like to Fibb to...");
            double userInput = Convert.ToDouble(Console.ReadLine());
            Fibbonacci Fibb = new Fibbonacci(userInput);

            TakeMeToYouTube youTube = new TakeMeToYouTube();
            Console.ReadLine();

        }
    }
}

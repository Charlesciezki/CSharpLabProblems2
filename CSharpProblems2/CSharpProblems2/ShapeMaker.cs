using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace CSharpProblems2
{
    class ShapeMaker
    {
        public List<List<string>> ListOfLists = new List<List<string>>();
        public ShapeMaker(int NumberOfRows)
        {

            for (int outterIndex = 0; outterIndex < NumberOfRows; outterIndex++)
            {
                ListOfLists.Add(new List<string>());

                for (int innerIndex = 0; innerIndex < NumberOfRows; innerIndex++)
                {
                    ListOfLists[outterIndex].Add("*");
                }

            }
        }

        public void PrintOutForward()
        {
            for (int outterIndex = 0; outterIndex < ListOfLists.Count; outterIndex++)
            {
                Console.WriteLine();
                for (int innerIndex = 0; innerIndex < outterIndex + 1; innerIndex++)
                {
                    Console.Write(ListOfLists[outterIndex][innerIndex]);
                }
            }
           }

        public void PrintOutUpSideDown()
        {
            Console.WriteLine();
            for (int outterIndex = 4; outterIndex >= 0; outterIndex--)
            {
                Console.WriteLine();
                for (int innerIndex = 0; innerIndex < outterIndex; innerIndex++)
                {
                    Console.Write(ListOfLists[outterIndex][innerIndex]);
                }
            }
        }

        public void PrintOutBackWard()
        {
            for (int outterIndex = 0; outterIndex < ListOfLists.Count; outterIndex++)
            {
                for (int innerIndex = 0; innerIndex < ListOfLists.Count - outterIndex; innerIndex++)
                {
                    Console.Write(" ");
                }
                for (int innerIndex = 0; innerIndex <= outterIndex  ; innerIndex++)
                {
                    Console.Write(ListOfLists[outterIndex][innerIndex]);
                }
                Console.WriteLine("");
            }

        }

    }
}


using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpProblems2
{
    class Fibbonacci
    {
        public Fibbonacci(int number)
        {
            int first;
            int second;
            int third;

            for (first = 0, second = 1, third = 0; third <= number; third = first + second)
            {
                first = second;
                second = third;
                Console.WriteLine(second + " ");
            }
        }

    }
}

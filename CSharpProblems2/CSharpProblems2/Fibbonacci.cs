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
        List<double> FibbList = new List<double>(); 
        public Fibbonacci(double number)
        {
            FibbList.Add(number);
            FibbList.Add(number);

            for (int i = 1; i < 50; i++)
            {
                double newNumber = FibbList[i] + FibbList[i - 1];
                FibbList.Add(newNumber);
            }
            foreach (var temp in FibbList)
            {
                Console.WriteLine(temp);
            }
        }

    }
}

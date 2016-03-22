using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpProblems2
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isrunning = true;
            while (isrunning)
            {
                UserInputChecker userInputListChecker = new UserInputChecker();
                userInputListChecker.checkAgainstList();
            }

        }
    }
}

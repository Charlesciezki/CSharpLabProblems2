﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CSharpProblems2
{
    class UserInputChecker
    {
        public List<string> userInputList = new List<string>();
        public string userInput;

        public void checkAgainstList()
        {
            userInputList.Add(" ");
            bool running = true;

                for (int index = 0; index < userInputList.Count; index++)
                {
            while (running)
            {
                    Console.WriteLine("Please enter a word, if entered twice, I will bark at you!");
                    userInput = Console.ReadLine();

                    for (int Index = 0; Index < userInputList.Count; Index++)
                    {
                        if (userInputList[Index] == userInput)
                        {
                            Console.WriteLine("Bark bark bark, cannot compute!");
                            Console.ReadLine();
                            running = false;
                        }
                    }
                    userInputList.Add(userInput);
                }
            }
        }

    }
}

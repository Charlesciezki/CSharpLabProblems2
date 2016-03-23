using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace CSharpProblems2
{
    class TakeMeToYouTube
    {
        
        public TakeMeToYouTube()
        {

            Process.Start(@"C:\Program Files (x86)\Google\Chrome\Application\chrome.exe", "https://www.youtube.com/watch?v=hl_9_q_uLF8");
            Console.ReadLine();
        }

        ~TakeMeToYouTube()
        {

            Process.Start(@"C:\Program Files (x86)\Google\Chrome\Application\chrome.exe", "https://youtu.be/JwXohnAYyuc?t=22s");
        }

        }
    }


global using System;
global using System.Collections.Generic;
global using System.Linq;
global using System.Security.Cryptography;
global using System.Text;
global using System.Threading.Tasks;

namespace CLI100Projects
{
    public class CLI100Projects
    {
        public static void Main(string[] args)
        {
            // Every interaction with possible CLI output can be called with Projects.[Name]...

            Projects.Hangman.Play();
        }
    }
}

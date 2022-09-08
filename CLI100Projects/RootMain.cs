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

             //Projects.DeEnCrypter.Encrypt("abcdefghijklmnop", "563247862");
            Projects.DeEnCrypter.Decrypt("485 885 -298 200 404 417 428 426 210 530 246 423 812 440 777 698", "563247862");


        }
    }
  
}

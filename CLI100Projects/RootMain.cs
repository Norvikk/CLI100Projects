global using System;
global using System.Collections.Generic;
global using System.Linq;
global using System.Security.Cryptography;
global using System.Text;
global using System.Threading.Tasks;
global using System.Numerics;

namespace CLI100Projects
{
    using static Kenny.Utilities;

    public class CLI100Projects
    {
        public static void Main(string[] args)
        {
            // Kenny
            WL("This will be its own line");
            W("Row");
            W("Row");
            W("Row");
            W("Row");

            List<string> list = new List<string>() { "1", "2", "5", "7", "8", "10" };
            List<int> listint = new List<int>() { 1, 2, 5, 7, 8, 10 };

            Sleep(1000);

            ListW(list); // throws every element from list in a line with default spacer " "
            ListW(list, spacer: "--"); // throws every element from list in a line + custom spacer --
            // => ArrayW, ArrayWL, ListW, ListWR <=



            //Vanilla C# equivalent
            Console.WriteLine("This will be its own line");
            Console.Write("Row");
            Console.Write("Row");
            Console.Write("Row");
            Console.Write("Row");

            List<string> list_ = new List<string>() { "1", "2", "5", "7", "8", "10" };
            List<int> listint_ = new List<int>() { 1, 2, 5, 7, 8, 10 };

            System.Threading.Thread.Sleep(1000);

            foreach (string item in list_)
            {
                Console.WriteLine(item + " ");
            }

            foreach (int item in listint_)
            {
                Console.WriteLine(item + "--");
            }
        }
    }
}

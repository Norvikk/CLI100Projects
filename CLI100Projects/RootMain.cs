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
            // Call the project from here with Projects.[name]... Example: =>
            Projects.SortingAlgorithm.Sort(1900);
        }
    }
}

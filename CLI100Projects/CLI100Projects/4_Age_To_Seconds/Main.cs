using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projects
{
    internal static class AgeToSeconds
    {
        public static Func<int, int, int, double> AgeInSeconds = (Year, Month, Day) => Math.Round((DateTime.Now - new DateTime(Year, Month, Day)).TotalSeconds);
    }
}

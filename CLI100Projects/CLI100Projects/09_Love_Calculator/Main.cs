using Spectre.Console;

namespace Projects
{
    internal static class LoveCalculator
    {
        private static readonly Random RandomNumber = new Random();
        public static void MeAnd()
        {
            string partner;
            Console.WriteLine("Match with who?");
            partner = Console.ReadLine();
            AnimateConsole(partner, RandomNumber.Next(0, 101));
            //Console.ReadLine();
        }

        public static void AnimateConsole(string partner, int percent)
        {
            AnsiConsole
                .Progress()
                .Start(async ctx =>
                {
                    // Define tasks
                    var task1 = ctx.AddTask(
                        $"[fuchsia] \u2665 Your Match capability with {partner} is: [/] "
                    );

                    while (task1.Percentage < percent)
                    {
                        task1.Increment(1);
                        System.Threading.Thread.Sleep(50);
                    }
                });
        }
    }
}

namespace Projects
{
    internal static class HigherLowerHeadsTail
    {
        private readonly static Random rand = new();

        public static void StartHigherLowerGame(int min, int max)
        {
            Console.WriteLine($"Place your guess between {min} and {max}!");

            int _number = rand.Next(min, max + 1);
            int _userInput = -0;

            while (_userInput != _number)
            {
                _userInput = Convert.ToInt32(Console.ReadLine());

                if (_userInput > _number) { Console.WriteLine("Lower!"); }
                else if (_userInput == _number) { Console.WriteLine($"You won!. The number was {_number}"); break; }
                else { Console.WriteLine("Higher!"); }
            }
        }

        public static string ReturnHeadsOrTail => rand.Next(0, 2) == 1 ? "Tails" : "Head";
    }
}

namespace Projects
{
    internal static class RockPaperScissors
    {
        public static readonly Random rand = new();

        public static void Play()
        {
            Console.WriteLine(
                "Rock Paper Scissors\n\nRules are simple: Paper beats Rock - Rock beats Scissors - Scissors beat Paper\n\nWinning 3 matches wins the round!\nPress ENTER to start!"
            );
            Console.ReadLine();
            Console.Clear();

            int timesWon = 0;
            bool endRun = false;
            while (!endRun)
            {
                while (!endRun)
                {
                    Console.WriteLine("Rock... Paper.. Scissors! (Choose your tool!) ");
                    string _botChoice = GetTool();
                    string _userChoice = Console.ReadLine();
                    if (string.IsNullOrEmpty(_userChoice))
                    {
                        Console.Clear();
                        Console.WriteLine("You MUST enter a tool to play!\n\n");
                        break;
                    }
                    Console.Clear();

                    Console.WriteLine($"You chose: {_userChoice} - The bot chose: {_botChoice}\n");
                    Console.WriteLine(ElaborateStatistics(ref timesWon, _userChoice, _botChoice));

                    if (timesWon == 3)
                    {
                        endRun = true;
                        Console.WriteLine("\n\n\nYou won the match!");
                        System.Threading.Thread.Sleep(2000);
                        break;
                    }
                    if (timesWon == -3)
                    {
                        endRun = true;
                        Console.WriteLine("\n\n\nYou lost the match...");
                        System.Threading.Thread.Sleep(2000);
                        break;
                    }
                }
            }

            string GetTool()
            {
                int _toolInt = rand.Next(0, 4);
                if (_toolInt == 1)
                {
                    return "Scissors";
                }
                else if (_toolInt == 2)
                {
                    return "Rock";
                }
                else
                {
                    return "Paper";
                }
            }

            string ElaborateStatistics(ref int timesWon, string userChoice, string botChoice)
            {
                if (userChoice.ToLower() == "rock" && botChoice.ToLower() == "scissors")
                {
                    timesWon++;
                    return "You Won!\n";
                }
                else if (userChoice.ToLower() == "scissors" && botChoice.ToLower() == "paper")
                {
                    timesWon++;
                    return "You Won!\n";
                }
                else if (userChoice.ToLower() == "paper" && botChoice.ToLower() == "rock")
                {
                    timesWon++;
                    return "You Won!\n";
                }
                else if (userChoice.ToLower() == botChoice.ToLower())
                {
                    return "Hah. Its a draw!\n";
                }
                else
                {
                    timesWon--;
                    return "Looks like you lost!";
                }
            }
        }
    }
}

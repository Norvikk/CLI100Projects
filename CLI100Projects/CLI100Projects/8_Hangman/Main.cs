namespace Projects
{
    internal static class Hangman
    {
        public static readonly Random rand = new();

        static int triesLeft = 8;
        static bool shouldEnd = false;
        static List<string> knownCharacters = new();
        static string hiddenWord = GetHiddenWord;

        public static void Play()
        {
            Console.WriteLine(
                "Welcome to Hangman\n\nRules are that you need to guess multiple words by suggesting a letter.\nIf you don't guess the right letter 8 times you lose.\n\n\nPress ENTER to start!"
            );
            Console.ReadLine();
            Console.Clear();

            while (!shouldEnd)
            {
                HideWord(knownCharacters, hiddenWord);
                Console.Write("\n\n");

                string _carrier1 = GetCharacter();
                Console.Clear();
                CompareData(_carrier1, ref knownCharacters, hiddenWord);
            }

            Console.WriteLine($"The word was: {hiddenWord}");
            System.Threading.Thread.Sleep(5000);
        }

        static string GetHiddenWord =>
            $"{Words.MixedWords[rand.Next(Words.MixedWords.Length)]} {Words.MixedWords[rand.Next(Words.MixedWords.Length)]}";

        static void HideWord(List<string> knownCharacters, string keyWord)
        {
            string _result = "";
            foreach (string character in keyWord.ToCharArray().Select(c => c.ToString()).ToArray())
            {
                if (character == " ")
                {
                    _result += " --- ";
                }
                else if (knownCharacters.Contains(character))
                {
                    _result += $" {character.ToUpper()} ";
                }
                else
                {
                    _result += " _ ";
                }
            }
            Console.WriteLine(_result);
        }

        static string GetCharacter()
        {
            Console.WriteLine("What letter do you think goes there?");
            string _userInput = Console.ReadLine();

            while (string.IsNullOrEmpty(_userInput))
            {
                Console.WriteLine("That was not quite right.. Again");
                _userInput = Console.ReadLine();
            }

            return _userInput;
        }

        static void CompareData(string character, ref List<string> knownCharacters, string keyWord)
        {
            string _return = "";

            if (keyWord.Contains(character))
            {
                if (!knownCharacters.Contains(character))
                {
                    knownCharacters.Add(character);
                    _return = $"Great! {character} is correct!";
                }
                else
                {
                    triesLeft--;
                    _return = $"Awkard.. You already chose {character}. This counts as wrong";
                }
            }
            else
            {
                triesLeft--;
                _return = $"{character} is wrong";
            }

            if (triesLeft == 0)
            {
                shouldEnd = true;
            }
            Console.WriteLine($"{_return} : {OutputSlur()} \n");
        }

        static string OutputSlur()
        {
            switch (triesLeft)
            {
                case 8:
                    return $"Phew, I'm still whole - {triesLeft}/8";
                case 7:
                    return $"God, that's where I'm going to hang - {triesLeft}/8";
                case 6:
                    return $"NO, my head is hanging! - {triesLeft}/8";
                case 5:
                    return $"NO, my body is hanging! - {triesLeft}/8";
                case 4:
                    return $"NO, my one arm is hanging! - {triesLeft}/8";
                case 3:
                    return $"NO, my other arm is hanging! - {triesLeft}/8";
                case 2:
                    return $"NO, my one leg is hanging! - {triesLeft}/8";
                case 1:
                    return $"NO, my other leg is hanging! - {triesLeft}/8";
                case 0:
                    return $"I'm hanging entirely..! - {triesLeft}/8";
                default:
                    return null;
            }
        }
    }
}

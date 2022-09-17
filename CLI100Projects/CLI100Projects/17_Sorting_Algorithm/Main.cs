namespace Projects
{
    internal static class SortingAlgorithm
    {
        private static readonly Random rand = new Random();

        public static void Sort(int randomCalls)
        {
            List<int> _mixedCalls = new List<int>();

            for (int i = 0; i < randomCalls; i++)
            {
                _mixedCalls.Add(rand.Next(0, randomCalls));
            }

            foreach (int call in _mixedCalls)
            {
                Console.Write(call + " ");
            }

            for (int a = 0; a < 2 * randomCalls; a++)
            {
                for (int i = 0; i < _mixedCalls.Count; i++)
                {
                    if (i + 1 == _mixedCalls.Count)
                    {
                        break;
                    }

                    if (_mixedCalls[i] > _mixedCalls[i + 1])
                    {
                        var tmp = _mixedCalls[i];
                        _mixedCalls[i] = _mixedCalls[i + 1];
                        _mixedCalls[i + 1] = tmp;
                    }
                }
            }

            Console.WriteLine("\n");
            foreach (int call in _mixedCalls)
            {
                Console.Write(call + " ");
            }
        }
    }
}

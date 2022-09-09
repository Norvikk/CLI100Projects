namespace DeEnCrypter.Sequences
{
    static class Tool
    {
        public static int InfinityLoop(int size, int currentRun)
        {
            while (currentRun >= size)
            {
                currentRun -= size;
            }
            return currentRun;
        }

        public static int ReverseInt(int num) =>
            num.ToString().Reverse().Aggregate(0, (b, x) => 10 * b + x - '0');
    }

    public class SA // SequenceAccess
    {
        public static List<int>? _byteList;
        public static List<int>? _intList;
    }

    // By adding more Sequences it becomes more secure and hard to reverse engineer. Fiddle around
    internal static class Sequences
    {
        public static void S0()
        {
            SA._byteList = Projects.DeEnCrypter.CommonRedistributables.payload
                .Select(x => Convert.ToInt32(Convert.ToByte(x)))
                .ToList();
            SA._intList = Projects.DeEnCrypter.CommonRedistributables.password
                .Select(x => Convert.ToInt32(x.ToString()))
                .ToList();

            for (int i = 0; i < SA._byteList.Count; i++)
            {
                Console.Write(
                    Convert.ToChar(SA._byteList[i])
                        + ":"
                        + SA._intList[Tool.InfinityLoop(SA._intList.Count, i)]
                        + "  "
                );
            }

            S1(); // Removes the accuracy of each item
            foreach (var a in SA._byteList)
            {
                Console.Write(a + ": ");
            }
        }

        public static void S1()
        {
            for (int i = 0; i < SA._byteList.Count; i++)
            {
                SA._byteList[i] *= SA._intList[Tool.InfinityLoop(SA._intList.Count, i)];
            }
        }
    }
}

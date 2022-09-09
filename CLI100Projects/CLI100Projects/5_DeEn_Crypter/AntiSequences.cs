namespace DeEnCrypter.AntiSequences
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

        public static int ReverseI(int num) =>
            num.ToString().Reverse().Aggregate(0, (b, x) => 10 * b + x - '0');

        public static int ReverseInt(int s)
        {
            char[] charArray = s.ToString("D3").ToCharArray();
            Array.Reverse(charArray);
            return Convert.ToInt32(new string(charArray));
        }
    }

    public class ASA // AntiSequenceAccess
    {
        public static List<int>? _byteList;
        public static List<int>? _intList;
    }

    internal static class AntiSequences
    {
        // By adding more AntiSequences you reverse engineered a sequence therefore it became less secure until decrypted
        public static void AS0()
        {
            string[] _carrier1 = Projects.DeEnCrypter.CommonRedistributables.payload.Split(" ");
            ASA._byteList = _carrier1.Select(s => int.Parse(s)).ToList();
            ASA._intList = Projects.DeEnCrypter.CommonRedistributables.password
                .Select(x => Convert.ToInt32(x.ToString()))
                .ToList();

            AS1(); // Recreates the accuracy of each item
            foreach (var a in ASA._byteList)
            {
                Console.Write(a + " ");
            }
            Console.Write("\n");

            foreach (var a in ASA._byteList)
            {
                Console.Write(Convert.ToChar(a) + " ");
            }
        }

        public static void AS1()
        {
            for (int i = 0; i < ASA._byteList.Count; i++)
            {
                ASA._byteList[i] /= ASA._intList[Tool.InfinityLoop(ASA._intList.Count, i)];
            }
        }
    }
}

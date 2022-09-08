using DeEnCrypter.Sequences;

namespace DeEnCrypter.AntiSequences
{
    static class Tool
    {
        public static int InfinityLoop(int size, int currentRun)
        {
            while (currentRun >= size) { currentRun -= size; }
            return currentRun;
        }

        public static int ReverseI(int num) => num.ToString().Reverse().Aggregate(0, (b, x) => 10 * b + x - '0');

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
        public static void AS0()
        {
            string[] _carrier1 = Projects.DeEnCrypter.CommonRedistributables.payload.Split(" ");
            ASA._byteList = _carrier1.Select(s => int.Parse(s)).ToList();
            ASA._intList = Projects.DeEnCrypter.CommonRedistributables.password.Select(x => Convert.ToInt32(x.ToString())).ToList();


            AS3();
            foreach (var a in ASA._byteList) { Console.Write(a + " "); } Console.Write("\n");
            Console.WriteLine("485 588 297 200 404 714 824 624 210 530 642 324 218 440 777 896");

            Console.Write("\n");

            AS1(); // Recreates the accuracy of each item
            foreach (var a in ASA._byteList) { Console.Write(a + " "); } Console.Write("\n");
            Console.WriteLine("97 98 99 100 101 102 103 104 105 106 107 108 109 110 111 112");

            Console.Write("\n");




            foreach (var a in ASA._byteList) { Console.Write(Convert.ToChar(a) + " "); } Console.Write("\n");
            Console.Write("a b c d e f g h i j k l m n o p");
        }

        public static void AS1()
        {
            for (int i = 0; i < ASA._byteList.Count; i++)
            {
               ASA._byteList[i] /= ASA._intList[Tool.InfinityLoop(ASA._intList.Count, i)];
            }
        }

        public static void AS3()
        {
            for (int i = 0; i < ASA._byteList.Count; i++)
            {
                if (ASA._byteList[i].ToString().Contains("-")) { ASA._byteList[i] = ~ASA._byteList[i]; }
                //
            }
        }
    }
}


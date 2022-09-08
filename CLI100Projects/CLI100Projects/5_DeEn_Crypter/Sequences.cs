namespace DeEnCrypter.Sequences
{
    static class Tool
    {
        public static int InfinityLoop(int size, int currentRun)
        {
            while (currentRun >= size) { currentRun -= size; }
            return currentRun;
        }

        public static int ReverseInt(int num) => num.ToString().Reverse().Aggregate(0, (b, x) => 10 * b + x - '0');

    }

    public class SA // SequenceAccess
    {
        public static List<int>? _byteList;
        public static List<int>? _intList;
    }
    internal static class Sequences
    {
        public static void S0()
        {
            SA._byteList = Projects.DeEnCrypter.CommonRedistributables.payload.Select(x => Convert.ToInt32(Convert.ToByte(x))).ToList();
            SA._intList = Projects.DeEnCrypter.CommonRedistributables.password.Select(x => Convert.ToInt32(x.ToString())).ToList();

           

           for (int i = 0; i < SA._byteList.Count; i++)
            {
                Console.Write(Convert.ToChar(SA._byteList[i]) + ":" + SA._intList[Tool.InfinityLoop(SA._intList.Count, i)]+ "  ");
            }
        
            
                
            Console.WriteLine(" Sequence0 : Raw Content");

            S1(); // Removes the accuracy of each item
            foreach (var a in SA._byteList) { Console.Write(a + ": "); }
            Console.WriteLine(" Sequence1 : Basic Modification + - *");

            
            S2(); // Fragment III Iteration
            foreach (var a in SA._byteList) { Console.Write(a + ": "); }
            Console.WriteLine(" Sequence2");

            S3();  // Reverses all non-nullable codes
            foreach (var a in SA._byteList) { Console.Write(a + ": "); }
            Console.WriteLine(" Sequence3 : Spun int around");
            Console.WriteLine("485: 588: 297: 200: 404: 714: 824: 624: 210: 530: 642: 324: 218: 440: 777: 896:");

        }

        public static void S1()
        {
            for (int i = 0; i < SA._byteList.Count; i++)
            {
                SA._byteList[i] *= SA._intList[Tool.InfinityLoop(SA._intList.Count, i)];
            }
        }
        public static void S2()
        {
            //List<int> _Fragments = Enumerable.Range(0, SA._intList.Count + 1).TakeLast(3).ToList();
            //foreach (int i in _Fragments) {  }
            
        }
        public static void S3()
        {
            for (int i = 0; i < SA._byteList.Count; i++)
            {
                try
                {
                    if ((SA._intList[Tool.InfinityLoop(SA._intList.Count, i)] % i) == 1) { SA._byteList[i] = ~SA._byteList[i]; }
                    else
                    {
                        if (!Convert.ToString(SA._byteList[i]).EndsWith("0"))
                        { SA._byteList[i] = Tool.ReverseInt(SA._byteList[i]); }

                        // Console.WriteLine(SA._byteList[i] + ":" + References.ReverseInt(SA._byteList[i]));
                    }
                } // REVERSED MISERY DOESNT WORK
                catch (DivideByZeroException) { };
            }
        }
    }
}

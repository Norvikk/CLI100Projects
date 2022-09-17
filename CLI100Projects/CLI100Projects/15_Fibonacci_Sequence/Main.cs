namespace Projects
{
    internal static class Fibonnaci
    {
        public static void OuputNext(int iterations)
        {
            int a = 0, b = 1, c = 0;

            for (int i = 0; i < iterations; i++)
            {
                c = a + b;
                a = b;
                b = c;
                Console.Write(c + " ");
            }
        }
    }
}

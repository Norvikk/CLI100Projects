namespace Projects
{
    internal static class Factorial
    {
        public static void Get(int factorial)
        {
            BigInteger fact = 1;
           
            
            for (int i = 1; i <= factorial; i++)
            {
                fact = fact * i;
            }
            Console.Write("Factorial of " + factorial + " is: " + fact);
            Console.ReadLine();
        }
    }
}


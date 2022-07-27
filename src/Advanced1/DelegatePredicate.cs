using System;

namespace Advanced1
{
    public class DelegatePredicate
    {
        
        public delegate bool CheckValue(int number);

        public DelegatePredicate(int n)
        {
            CheckValue isMultipleOfThree = x => x % 3 == 0;
            Console.WriteLine($"Is {n} a multiple of 3? {isMultipleOfThree(n)}");
        }
    }
}
using System;

namespace DS
{
    public class PrimeService
    {
        public bool IsPrime(int num)
        {
            var result = true;
            if (num <= 1) return false;

            for (int i = 2; i * i <= num; i++)
            {
                if (num % i == 0)
                {
                    result = false;
                    break;
                }
            }

            //Console.WriteLine($"{num} is Prime? {result}");
            return result;
        }
    }
}

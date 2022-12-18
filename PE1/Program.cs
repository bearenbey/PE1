using System;

namespace PE1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * If we list all the natural numbers below 10 that are multiples
             * of 3 or 5, we get 3, 5, 6 and 9. The sum of these multiples is 23.
             * Find the sum of all the multiples of 3 or 5 below 1000.
             */
            
            int[] myList = Enumerable.Range(1, 999).ToArray();
            List<int> newList = new List<int>();

            foreach (int number in myList)
            {
                if (number % 3 == 0 || number % 5 == 0)
                {
                    newList.Add(number);
                }
            }

            List<int> cleanList = newList.Distinct().ToList();
            int sum = cleanList.Sum();
            
            Console.WriteLine(sum);
        }
    }
}
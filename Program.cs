using System;
using System.Collections.Generic;
using System.Linq;

namespace Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. Receive 2 arrays - 1st numbers, 2nd string
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            string text = Console.ReadLine();
            List<string> result = new List<string>();
            List<string> word = new List<string>();

            for (int i = 0; i < text.Length; i++)
            {
                result.Add(text[i].ToString());
            }
            // 2. Spliting numbers array and sum different nums
            for (int i = 0; i < numbers.Count; i++)
            {
                int sum = 0;
                int num = numbers[i];
                while (num != 0)
                {
                    sum += num % 10;
                    num /= 10;
                }
                // 2.1. Substract only if sum is bigger than array.length
                if (sum > result.Count)
                {
                    sum -= result.Count;
                }
                // 3. When i find index add char to new array and delete from other
                for (int j = 0; j < result.Count; j++)
                {
                    if (j == sum)
                    {
                        word.Add(result[j].ToString());
                        result.Remove(result[j]);
                        break;
                    }

                }

            }
            // 4. Print 
            Console.WriteLine(string.Join("", word));
        }
    }
}

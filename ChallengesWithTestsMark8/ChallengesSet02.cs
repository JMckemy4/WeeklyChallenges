using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet02
    {
        public bool CharacterIsALetter(char c)
        {
            return char.IsLetter(c);
        }
        public bool CountOfElementsIsEven(string[] vals)
        {
            if (vals == null)
            {
                throw new ArgumentNullException(nameof(vals));
            }

            return vals.Length % 2 == 0;
        }
        public bool IsNumberEven(int number)
        {
            return number % 2 == 0;
        }
        public bool IsNumberOdd(int num)
        {

            return num % 2 != 0;
        }

        public double SumOfMinAndMax(IEnumerable<double> numbers)
        {
            if (numbers == null || !numbers.Any())
            {
                return 0; 
            }

            double min = numbers.Min();
            double max = numbers.Max();

            return min + max;
        }
            public int GetLengthOfShortestString(string str1, string str2)
        {
            int length1 = str1.Length; 
            int length2 = str2.Length; 

            int minLength = Math.Min(length1, length2); 

            return minLength;
        }

        public int Sum(int[] numbers)
        {
            if (numbers == null)
            {
                return 0; 
            }

            int sum = 0;

            foreach (int num in numbers)
            {
                sum += num; 
            }

            return sum; 
        }

        public int SumEvens(int[] numbers)
        {
            if (numbers == null)
            {
                return 0; 
            }

            int sum = 0; 

            foreach (int num in numbers)
            {
                if (num % 2 == 0) 
                {
                    sum += num;
                }
            }

            return sum; 
        }

        public bool IsSumOdd(List<int> numbers)
        {
            if (numbers == null || numbers.Count == 0)
            {
                return false; 
            }

            int sum = 0; 

            foreach (int num in numbers)
            {
                sum += num; 
            }

            return sum % 2 != 0; 
        }

        public long CountOfPositiveOddsBelowNumber(long number)
        {
            if (number <= 1)
            {
                return 0; 
            }

            long count = 0; 

            for (long i = 1; i < number; i += 2)
            {
                count++; 
            }

            return count;
        }
    }
}

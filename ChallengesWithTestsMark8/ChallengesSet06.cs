using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet06
    {
        public bool CollectionContainsWord(IEnumerable<string> words, string word, bool ignoreCase)
        {
            if (words == null)
            {
                return false; // Return false when words is null
            }

            if (ignoreCase)
            {
                // Case-insensitive search
                return words.Any(w => string.Equals(w, word, StringComparison.OrdinalIgnoreCase));
            }
            else
            {
                // Case-sensitive search
                return words.Contains(word);
            }
        }
        public bool IsPrimeNumber(int num)
        {
            if (num <= 1)
            {
                return false; // Numbers less than or equal to 1 are not prime
            }

            if (num <= 3)
            {
                return true; // 2 and 3 are prime
            }

            if (num % 2 == 0 || num % 3 == 0)
            {
                return false; // Numbers divisible by 2 or 3 are not prime
            }

            int i = 5;
            while (i * i <= num)
            {
                if (num % i == 0 || num % (i + 2) == 0)
                {
                    return false; // Numbers divisible by i or i+2 are not prime
                }
                i += 6; // Optimized to check for divisors at 6k ± 1
            }

            return true; // If no divisors are found, the number is prime
        }

        public int IndexOfLastUniqueLetter(string str)
        {
            if (string.IsNullOrEmpty(str))
            {
                return -1; // Return -1 for empty or null strings
            }

            Dictionary<char, int> letterIndices = new Dictionary<char, int>();

            for (int i = str.Length - 1; i >= 0; i--)
            {
                char currentChar = str[i];

                if (letterIndices.ContainsKey(currentChar))
                {
                    letterIndices[currentChar] = -1; // Mark this character as non-unique
                }
                else
                {
                    letterIndices[currentChar] = i; // Store the index of this character
                }
            }

            int lastUniqueIndex = -1;

            foreach (var kvp in letterIndices)
            {
                if (kvp.Value != -1 && (lastUniqueIndex == -1 || kvp.Value > lastUniqueIndex))
                {
                    lastUniqueIndex = kvp.Value; // Update the last unique index
                }
            }

            return lastUniqueIndex;
        }

        public int MaxConsecutiveCount(int[] numbers)
        {
            if (numbers == null || numbers.Length == 0)
            {
                return 0; // Return 0 for null or empty arrays
            }

            int maxCount = 1; // Initialize the maximum consecutive count to 1
            int currentCount = 1; // Initialize the current consecutive count to 1

            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] == numbers[i - 1])
                {
                    currentCount++; // Increment the current consecutive count
                }
                else
                {
                    currentCount = 1; // Reset the current consecutive count
                }

                if (currentCount > maxCount)
                {
                    maxCount = currentCount; // Update the maximum consecutive count
                }
            }

            return maxCount;
        }

        public double[] GetEveryNthElement(List<double> elements, int n)
        {
            if (elements == null || elements.Count == 0 || n <= 0)
            {
                return new double[0]; // Return an empty array for null, empty, or invalid input
            }

            List<double> result = new List<double>();

            for (int i = n - 1; i < elements.Count; i += n)
            {
                result.Add(elements[i]);
            }

            return result.ToArray();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text.RegularExpressions;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet05
    {
        public int GetNextNumberDivisibleByN(int startNumber, int n)
        {
            return (startNumber == 0) ? n : startNumber + (n - (startNumber % n));

        }


        public void ChangeNamesOfBusinessesWithNoRevenueTo_CLOSED(Business[] businesses)
        {
            foreach (Business business in businesses)
            {
                if (business.TotalRevenue == 0d)
                {
                    business.Name = "CLOSED";
                }
            }
        }

        public bool IsAscendingOrder(int[] nums)
        {
            if (nums == null || nums.Length == 0)
            {
                return false;
            }
            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[i] < nums[i - 1])
                {
                    return false;
                }
            }
                return true;
            }
        
    
    
            public int SumElementsThatFollowAnEven(int[] numbers)
        {
            if (numbers == null || numbers.Length < 2)
            {
                return 0; // Not enough elements to follow an even number
            }

            int sum = 0;
            for (int i = 0; i < numbers.Length - 1; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    sum += numbers[i + 1]; // Add the element that follows an even number
                }
            }

            return sum;
        }

        public string TurnWordsIntoSentence(string[] words)
        {
            if (words == null || words.Length == 0)
            {
                return string.Empty; // Return an empty string for null or empty input
            }

            // Filter out empty or whitespace-only strings and join the words with a single space between them
            string sentence = string.Join(" ", words.Where(word => !string.IsNullOrWhiteSpace(word))).Trim();

            // Capitalize the first letter of the sentence
            if (!string.IsNullOrWhiteSpace(sentence))
            {
                sentence = char.ToUpper(sentence[0]) + sentence.Substring(1);
            }

            // Add a period at the end if it's missing
            if (!string.IsNullOrWhiteSpace(sentence) && !sentence.EndsWith("."))
            {
                sentence += ".";
            }
            // Replace multiple spaces with a single space
            sentence = Regex.Replace(sentence, @"\s+", " ");

            return sentence;
        }

        public double[] GetEveryFourthElement(List<double> elements)
        {
            if (elements == null || elements.Count == 0)
            {
                return new double[0]; // Return an empty array for null or empty input
            }

            List<double> result = new List<double>();

            for (int i = 3; i < elements.Count; i += 4)
            {
                result.Add(elements[i]);
            }

            return result.ToArray();
        }

        public bool TwoDifferentElementsInArrayCanSumToTargetNumber(int[] nums, int targetNumber)
        {
            if (nums == null || nums.Length < 2)
            {
                return false; // Not enough elements to form a sum
            }

            HashSet<int> seenElements = new HashSet<int>();

            foreach (int num in nums)
            {
                int complement = targetNumber - num;

                if (seenElements.Contains(complement))
                {
                    return true; // Found two different elements that sum to the targetNumber
                }

                seenElements.Add(num);
            }

            return false; // No two different elements found that sum to the targetNumber
        }
    }
}

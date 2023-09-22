using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet03
    {
        public bool ArrayContainsAFalse(bool[] vals)
        {
            if (vals == null)
            {
                throw new ArgumentNullException(nameof(vals));
            }

            foreach (bool value in vals)
            {
                if (!value)
                {
                    return true; // Found a 'false' value
                }
            }

            return false; // No 'false' value found
        }

        public bool IsSumOfOddsOdd(IEnumerable<int> numbers)
        {
            if (numbers == null)
            {
                return false; // Sum of nothing is considered even
            }

            int sum = 0;
            foreach (int number in numbers)
            {
                if (number % 2 != 0) // Check if the number is odd
                {
                    sum += number;
                }
            }

            return sum % 2 != 0; // Check if the sum is odd
        }

        public bool PasswordContainsUpperLowerAndNumber(string password)
        {
            if (string.IsNullOrWhiteSpace(password))
            {
                throw new ArgumentException("Password cannot be null or empty.", nameof(password));
            }

            return password.Any(char.IsUpper) && password.Any(char.IsLower) && password.Any(char.IsDigit);
        }

        public char GetFirstLetterOfString(string val)
        {
            if (string.IsNullOrEmpty(val))
            {
                // Handle null or empty input string, depending on your requirements
                throw new ArgumentException("Input string cannot be null or empty.", nameof(val));
            }

            return val[0];
        }

        public char GetLastLetterOfString(string val)
        {
            if (string.IsNullOrEmpty(val))
            {
                // Handle null or empty input string, depending on your requirements
                throw new ArgumentException("Input string cannot be null or empty.", nameof(val));
            }

            return val[val.Length - 1];
        }

        public decimal Divide(decimal dividend, decimal divisor)
        {
            if (divisor == 0)
            {
                // Handle division by zero, returning 0 for this method
                return 0;
            }

            return dividend / divisor;
        }

        public int LastMinusFirst(int[] nums)
        {
            if (nums == null || nums.Length == 0)
            {
                // Handle null or empty array, depending on your requirements
                throw new ArgumentException("Input array cannot be null or empty.", nameof(nums));
            }

            int lastIndex = nums.Length - 1;
            return nums[lastIndex] - nums[0];
        }

        public int[] GetOddsBelow100()
        {
            List<int> oddNumbers = new List<int>();

            for (int i = 1; i < 100; i += 2)
            {
                oddNumbers.Add(i);
            }

            return oddNumbers.ToArray();
        }

        public void ChangeAllElementsToUppercase(string[] words)
        {
            if (words == null)
            {
                // Handle null input array, depending on your requirements
                throw new ArgumentNullException(nameof(words));
            }

            for (int i = 0; i < words.Length; i++)
            {
                if (words[i] != null)
                {
                    words[i] = words[i].ToUpper();

                }
            }
        }
    }
}

using System;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet04
    {
        public int AddEvenSubtractOdd(int[] numbers)
        {
            int sumEven = 0;
            int sumOdd = 0;

            foreach (int num in numbers)
            {
                if (num % 2 == 0)
                {
                    // Add even numbers to sumEven
                    sumEven += num;
                }
                else
                {
                    // Add odd numbers to sumOdd
                    sumOdd += num;
                }
            }

            // Subtract the sum of odd numbers from the sum of even numbers
            int result = sumEven - sumOdd;
            return result;
        }

        public int GetLengthOfShortestString(string str1, string str2, string str3, string str4)
        {
            int shortestLength = Math.Min(Math.Min(Math.Min(str1.Length, str2.Length), str3.Length), str4.Length);
            return shortestLength;
        }

        public int GetSmallestNumber(int number1, int number2, int number3, int number4)
        {
            return Math.Min(Math.Min(Math.Min(number1, number2), number3), number4);
        }

        public void ChangeBusinessNameTo_TrueCoders(Business biz)
        {
            // Check if the provided 'biz' object is not null
            if (biz != null)
            {
                // Set the name of the 'biz' object to "TrueCoders"
                biz.Name = "TrueCoders";
            }
            else
            {
                // Handle the case where 'biz' is null 
                throw new ArgumentNullException("biz", "The 'biz' parameter cannot be null.");
            }
        }
        public bool CouldFormTriangle(int sideLength1, int sideLength2, int sideLength3)
        {
            // Check if the given side lengths can form a triangle
            bool canFormTriangle = (sideLength1 + sideLength2 > sideLength3) &&
                                   (sideLength1 + sideLength3 > sideLength2) &&
                                   (sideLength2 + sideLength3 > sideLength1);

            return canFormTriangle;
        }

        public bool IsStringANumber(string input)
        {
            // Attempt to parse the input string as a double
            if (double.TryParse(input, out double result))
            {
                // Parsing successful, so it's a valid number
                return true;
            }

            // Parsing failed, so it's not a valid number
            return false;
        }

        public bool MajorityOfElementsInArrayAreNull(object[] objs)
        {
            int nullCount = 0;
            int nonNullCount = 0;

            foreach (object obj in objs)
            {
                if (obj == null)
                {
                    nullCount++;
                }
                else
                {
                    nonNullCount++;
                }
            }

            // Check if the majority of elements are null
            return nullCount > nonNullCount;
        }

        public double AverageEvens(int[] numbers)
        {
            if (numbers == null || numbers.Length == 0)
            {
                // Handle the case where the input array is null or empty
                return 0.0; // Return a default value (0.0) or handle it differently based on your requirements
            }

            int sum = 0;          // Initialize a variable to store the sum of even numbers
            int count = 0;        // Initialize a variable to count the even numbers

            foreach (int number in numbers)
            {
                if (number % 2 == 0)  // Check if the number is even
                {
                    sum += number;    // Add the even number to the sum
                    count++;          // Increment the count
                }
            }

            // Calculate the average (handle division by zero)
            double average = count > 0 ? (double)sum / count : 0.0;

            return average;
        }

        public int Factorial(int number)
        {
            if (number < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(number), "Input must be a non-negative integer.");
            }

            int result = 1;  // Initialize the result to 1

            for (int i = 2; i <= number; i++)
            {
                result *= i;  // Multiply the result by 'i'
            }

            return result;
        }
    }
}

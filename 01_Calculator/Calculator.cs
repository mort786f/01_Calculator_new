using System;

namespace _01_Calculator
{
    public class Calculator
    {
        public static int Add(int v1, int v2)
        {
            return v1 + v2;
        }

        public static int Subtract(int v1, int v2)
        {
            return v1 - v2;
        }

        public static int Sum(int[] numbers)
        {
            int allSum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                allSum = allSum + numbers[i];
            }
            return allSum;

        }

        public static int Multiply(int v1, int v2)
        {
            return v1 * v2;
        }

        public static int Power(int v1, int v2)
        {
            int allSum = 1;
            for (int i = 0; i < v2; i++)
            {
                allSum = allSum * v1;
            }
            return allSum;
        }

        public static int Factorial(int v)
        {
            int allSum = 1;
            for (int i = v; i > 0; i--)
            {
                allSum = allSum * i;
            }
            return allSum;
        }
    }
}
/**
 * Author:           Yashleen Kheterpal
 * Date:             03/29/2021
 * Assignment:       Midterm
 * Course: COMP494:  C#
 *
 */
using System;

namespace CalculatorLib
{
    public class Calculator
    {
        /// <summary>
        /// This class adds two doubles and return the sum
        /// </summary>
        /// <param name="a">It is double</param>
        /// <param name="b">It is double</param>
        /// <returns> The sum of a and b</returns>
        public double Add(double a, double b)
        {
            return a + b;
        }

        /// <summary>
        /// This class substract two integers and return the sum
        /// </summary>
        /// <param name="a">It is double</param>
        /// <param name="b">It is double</param>
        /// <returns>The difference of a and b</returns>
        public double Substract(double a, double b)
        {
            return a - b;
        }

        /// <summary>
        /// This class multiply two integers and return the sum
        /// </summary>
        /// <param name="a">It is double</param>
        /// <param name="b">It is double</param>
        /// <returns>The multiple of a and b</returns>
        public double Multiply(double a, double b)
        {
            return a * b;

        }

        /// <summary>
        /// This class divide two integers and return the sum
        /// </summary>
        /// <param name="a">It is double</param>
        /// <param name="b">It is double</param>
        /// <returns>The division of a by b</returns>
        public double Divide(double a, double b)
        {
            return a / b;
        }

        /// <summary>
        /// This class finds mean of an array of n numbers
        /// </summary>
        /// <param name="a">The array of doubles</param>
        /// <param name="n">The array of doubles</param>
        /// <returns>The average of given array with n numbers</returns>
        public double FindMean(double[] a, int n)
        {
            double sum = 0;
            for (int i = 0; i < n; i++)
                sum += a[i];

            return (double)(sum / n);
        }

        /// <summary>
        /// This class finds median of an array of n numbers
        /// </summary>
        /// <param name="a">The array of doubles</param>
        /// <param name="n">The number of doubles in the array (a)</param>
        /// <returns>The median of given array of n numbers</returns>
        public double FindMedian(double[] a, int n)
        {
            Array.Sort(a);

            if (n % 2 != 0)
                return (double)a[n / 2];

            return (double)(a[(n - 1) / 2] + a[n / 2]) / 2.0;

        }

    }
}

using System;

namespace HW3
{

    public class Calc
    {
        /// <summary>
        /// This class add two integers and return the sum
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public double Add(double a, double b)
        {
            return a + b;
        }

        /// <summary>
        /// This class substract two integers and return the sum
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public double Substract(double a, double b)
        {
            return a - b;
        }

        /// <summary>
        /// This class multiply two integers and return the sum
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public double Multiply(double a, double b)
        {
            return a * b;

        }

        /// <summary>
        /// This class divide two integers and return the sum
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public double Divide(double a, double b)
        {
            return a / b;
        }

        /// <summary>
        /// This class finds mean of an array of n numbers
        /// </summary>
        /// <param name="a"></param>
        /// <param name="n"></param>
        /// <returns></returns>
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
        /// <param name="a"></param>
        /// <param name="n"></param>
        /// <returns></returns>
        public double FindMedian(double[] a, int n)
        {
            Array.Sort(a);

            if (n % 2 != 0)
                return (double)a[n / 2];

            return (double)(a[(n - 1) / 2] + a[n / 2]) / 2;

        }
    }
}

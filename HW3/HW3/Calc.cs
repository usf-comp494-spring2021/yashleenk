using System;

namespace HW3
{

    public class Calc
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public double add(double a, double b)
        {
            return a + b;
        }

        public double sub(double a, double b)
        {
            return a - b;
        }

        public double mult(double a, double b)
        {
            return a * b;

        }

        public double divi(double a, double b)
        {
            return a / b;
        }

        public double findMean(double[] a, int n)
        {
            double sum = 0;
            for (int i = 0; i < n; i++)
                sum += a[i];

            return (double)(sum / n);
        }

        public double findMedian(double[] a, int n)
        {
            Array.Sort(a);

            if (n % 2 != 0)
                return (double)a[n / 2];

            return (double)(a[(n - 1) / 2] + a[n / 2]) / 2;

        }
    }
}

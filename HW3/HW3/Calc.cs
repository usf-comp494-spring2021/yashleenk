using System;

namespace HW3
{

    public class Calc
    {
        // add two integers and return the sum
        public double Add(double a, double b)
        {
            return a + b;
        }

        // Substract two integers and return the sum
        public double Substract(double a, double b)
        {
            return a - b;
        }

        // Multiply two integers and return the sum
        public double Multiply(double a, double b)
        {
            return a * b;

        }

        // Divide two integers and return the sum
        public double Divide(double a, double b)
        {
            return a / b;
        }

        // finding mean of an array of n numbers
        public double FindMean(double[] a, int n)
        {
            double sum = 0;
            for (int i = 0; i < n; i++)
                sum += a[i];

            return (double)(sum / n);
        }

        // finding median of an array of n numbers
        public double FindMedian(double[] a, int n)
        {
            Array.Sort(a);

            if (n % 2 != 0)
                return (double)a[n / 2];

            return (double)(a[(n - 1) / 2] + a[n / 2]) / 2;

        }
    }
}

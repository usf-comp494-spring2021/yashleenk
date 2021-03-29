/**
 * Author:           Yashleen Kheterpal
 * Date:             03/29/2021
 * Assignment:       Midterm
 * Course: COMP494:  C#
 *
 */

using CalculatorLib;
using System;
using System.IO;
using static System.IO.Path;

namespace TextFileProgram
{
    class Program
    {
        static void Main(string[] args)

        {
            // To get the current directory of the application
            string curDir = Directory.GetCurrentDirectory();


            // To display the current directory location
            Console.WriteLine($"The current directory is: {curDir}");

            // Define input file
            string inputFile = "CalcInput.txt";

            // To get the texts in the file CalcInput.txt from current directory
            StreamReader sr = File.OpenText(Combine(Directory.GetCurrentDirectory(), "CalcInput.txt"));

            sr.BaseStream.Seek(0, SeekOrigin.Begin);
            string str;

            Console.WriteLine($"Numbers from the input text file are: {inputFile}");

            double[] arrOfNum = new double[15];
            int size = 0;

            while ((str = sr.ReadLine()) != null)
            {
                Console.WriteLine(str);

                arrOfNum[size] = double.Parse(str);
                size++;
            }


            // Sorting the array in ascending order for later calculation 
            Array.Sort(arrOfNum, 0, size);

            // Calculating mean and median of the array
            var calc = new Calculator();

            double mean = calc.FindMean(arrOfNum, size);
            Console.WriteLine($"The mean: {mean}");

            double median = calc.FindMedian(arrOfNum, size);
            Console.WriteLine($"The median: {median}");

            // Creating the output file CalcOutput.txt
            string outputFile = "CalcuOutput.txt";
            StreamWriter text = File.CreateText(Combine(curDir, outputFile));

            // Writing into the output file
            text.WriteLine("There are the elements in the sorted array: ");

            foreach (double number in arrOfNum)
                text.Write($"{number} ");

            text.WriteLine(Environment.NewLine);

            // for writing to output text file
            text.WriteLine($"The Mean of the given numbers is: {mean}");
            text.WriteLine($"The Median of the given numbers is: {median} ");

            //release resources
            text.Close();
        }
    }
}

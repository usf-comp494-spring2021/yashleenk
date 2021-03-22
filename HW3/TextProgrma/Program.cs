using System;
using System.IO;
using static System.IO.Path;
namespace TextProgram
{
    class Program
    {
        static void Main(string[] args)
        {

            WorkWithText();
            ReadFile wr = new ReadFile();
            wr.DataReading();


        }

        class ReadFile
        {

            public void DataReading()
            {
                try
                {
                    StreamReader sr = new StreamReader(Combine(Directory.GetCurrentDirectory(), "CalcInput.txt"));

                    //This is to specify to start reading from the begining
                    sr.BaseStream.Seek(0, SeekOrigin.Begin);

                    // To read line from input stream 
                    string str = sr.ReadLine();

                    // To read the file line by line 
                    while (str != null)
                    {
                        Console.WriteLine(str);
                        str = sr.ReadLine();
                    }
                    Console.ReadLine();
                }
                catch(IOException e)
                {
                    Console.WriteLine("The file could not be read:");
                    Console.WriteLine(e.Message);
                }
            
                }// automatically calls dispose
        }

        static void WorkWithText()
        {
            //define an array of numbers 
            //define an array of numbers 
            string[] numbers = new string[] { "13.0", "27.8", "39.8", "1.5", "9.5", "19.9", "9.9", "6.28", "10.5",
                "77.7", "45.2", "3.3", "9.9", "54.8", "88.89" };


            //store the path of the textfile to write to
            string textFile = Combine(Directory.GetCurrentDirectory(), "CalcOutput.txt");

            //create a text file and return a helper writer
            StreamWriter text = File.CreateText(textFile);
            //to write each number on a seprate line
            foreach (string item in numbers)
            {
                text.WriteLine(item);

            }


            // for writing to output text file
            text.WriteLine("The Mean of the given numbers is:");

 

            text.WriteLine("The Median of the given numbers is:");

            //release resources
            text.Close();

            // output the contents of the file
            text.WriteLine("{0} contains {1:N0} bytes.",
            arg0: textFile,
            arg1: new FileInfo(textFile).Length);
            text.WriteLine(File.ReadAllText(textFile));
        }
    }
     
}

using System;
using System.IO;

namespace TextProgram
{
    class Program
    {
        class ReadFile
        {

            public void DataReading()
            {
                StreamReader sr = new StreamReader("CalcInput.txt");

                sr.BaseStream.Seek(0, SeekOrigin.Begin);

                // To read line from input stream 
                string str = sr.ReadLine();

                // To read the whole file line by line 
                while (str != null)
                {
                    Console.WriteLine(str);
                    str = sr.ReadLine();
                }
                Console.ReadLine();

                // to close the stream 
                sr.Close();

            }

            static void Main(string[] args)
            {
                ReadFile wr = new ReadFile();
                wr.DataReading();

            }
        }
    }

}

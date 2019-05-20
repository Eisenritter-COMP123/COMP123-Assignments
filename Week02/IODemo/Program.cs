using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace IODemo
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteFile("Text.txt");
            ReadFile("Text.txt");
            
        }

        static void WriteFile(string filename)
        {
            TextWriter writer = new StreamWriter(filename);
            writer.Write("Hello");
            writer.WriteLine(" from George");
            for (int i = 0; i <= 12; i++)
            {
                writer.WriteLine($"{i}*3 = {i * 3}");
            }
            writer.Close();
        }

        static void ReadFile(string filename)
        {
            TextReader reader = new StreamReader(filename);
            
                string line = "";
                int lineNO = 1;
                while ((line = reader.ReadLine()) != null)
                {
                    Console.WriteLine($"{lineNO++,5} {line,10}");
                }
                reader.Close();
        }

        static void Display(string filename)
        {
  
        }

    }
}

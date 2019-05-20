using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace MedalDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //create a medal object
            Medal m1 = new Medal("Horace Gwynne", "Boxing", "Gold", 2012, true);
            //print the object
            Console.WriteLine(m1);
            //print only the name of the medal holder
            Console.WriteLine(m1.Name);

            //assign a new object to m1
            m1 = new Medal("Michael Phelps", "Swimming", "Gold", 2012, false);
            //print the updated m1
            Console.WriteLine(m1);



            //create a list to store the medal objects
            List<Medal> medals = new List<Medal>();
            medals.Add(new Medal("Ryan Cochrane", "Swimming", "Silver", 2012, false));
            medals.Add(new Medal("Adam van Koeverden", "Canoeing", "Silver", 2012, false));
            medals.Add(new Medal("Rosie MacLennan", "Gymnastics", "Gold", 2012, false));
            medals.Add(new Medal("Christine Girard", "Weightlifting", "Bronze", 2012, false));
            medals.Add(new Medal("Charles Hamelin", "Short Track", "Gold", 2014, true));
            medals.Add(new Medal("Alexandre Bilodeau", "Freestyle skiing", "Gold", 2012, true));
            medals.Add(new Medal("Jennifer Jones", "Curling", "Gold", 2014, false));
            medals.Add(new Medal("Charle Cournoyer", "Short Track", "Bronze", 2014, false));
            medals.Add(new Medal("Mark McMorris", "Snowboarding", "Bronze", 2014, false));
            medals.Add(new Medal("Sidney Crosby ", "Ice Hockey", "Gold", 2014, false));
            medals.Add(new Medal("Brad Jacobs", "Curling", "Gold", 2014, false));
            medals.Add(new Medal("Ryan Fry", "Curling", "Gold", 2014, false));
            medals.Add(new Medal("Antoine Valois-Fortier", "Judo", "Bronze", 2012, false));
            medals.Add(new Medal("Brent Hayden", "Swimming", "Bronze", 2012, false));

            int i = 1;
            //prints a numbered list of 16 medals.
            foreach (Medal medal in medals)
            {
                Console.WriteLine($"{i++} {medal}");
            }
            Console.WriteLine();
            //prints a numbered list of 16 names
            i = 1;
            foreach (Medal medal in medals)
            {
                Console.WriteLine($"{i++} {medal.Name}");
            }
            Console.WriteLine();
            //prints a numbered list of 8 gold medals
            i = 1;
            foreach (Medal medal in medals)
            {
                if(medal.Color == "Gold") { 
                Console.WriteLine($"{i++} {medal}");
                }
            }
            Console.WriteLine();
            //prints a numbered list of 8 medals in 2012
            i = 1;
            foreach (Medal medal in medals)
            {
                if (medal.Year == 2012)
                {
                    Console.WriteLine($"{i++} {medal}");
                }
            }
            Console.WriteLine();
            //prints a numbered list of 2 gold medals in 2012
            i = 1;
            foreach (Medal medal in medals)
            {
                if (medal.Year == 2012 && medal.Color == "Gold")
                {
                    Console.WriteLine($"{i++} {medal}");
                }
            }
            Console.WriteLine();
            //prints a numbered list of 3 world record medals
            i = 1;
            foreach (Medal medal in medals)
            {
                if (medal.isRecord)
                {
                    Console.WriteLine($"{i++} {medal}");
                }
            }
            Console.WriteLine();
            WriteFile("Medals.txt", medals);
        }

        static void WriteFile(string filename, List<Medal> medals)
        {
            TextWriter writer = new StreamWriter(filename);
            foreach (Medal medal in medals)
            {
                writer.WriteLine($"{medal}");
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
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumDemo
{
    enum Day { Mon, Tue, Wed, Thu, Fri, Sat, Sun}
    [Flags]
    enum Genre { None=0, Comedy=1, Action=2, Documentary=4, Romance=8, Adult=16, Sci_Fi=32, Drama=64, Thriller=128}
    class Program
    {
        static void Main(string[] args)
        {
            //DayDemo();
            GenreDemo();
        }

        static void GenreDemo()
        {
            Genre genre = Genre.Comedy;
            Console.WriteLine(genre);
            if (genre == Genre.Documentary)
            {
                Console.WriteLine("it is a documentary");
            }
            else
            {
                Console.WriteLine("it is not a documentary");
            }

            genre = Genre.Drama | Genre.Action | Genre.Comedy;
            Console.WriteLine(genre);
            Console.WriteLine($"{(genre.HasFlag(Genre.Comedy) ? "Comedy":"Not Comedy")}");
        }

        static void DayDemo()
        {
            Day today = Day.Wed;
            Console.WriteLine($"-> {today}"); //prints Wed
            today++;
            Console.WriteLine($"-> {today}"); //prints Thu

            Console.Write("Enter a number less than 7: ");
            int x = Convert.ToInt32(Console.ReadLine());
            today = (Day) x;
            Console.WriteLine($"-> {today}"); //prints Day + 1

            Console.Write("Enter a day: ");
            string input = Console.ReadLine();
            today=(Day)Enum.Parse(typeof(Day), input); //Important//
            Console.WriteLine($"-> {today}"); //prints Day
        }
    }
}

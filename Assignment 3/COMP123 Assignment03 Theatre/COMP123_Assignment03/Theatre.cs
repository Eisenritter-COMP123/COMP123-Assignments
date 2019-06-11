using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP123_Assignment03
{
    class Theatre
    {
        //Set up Show List
        List<Show> shows = new List<Show>();
        //Theatre name Property
        public string Name { get; }
        
        //Theatre Constructor
        public Theatre(string name) {
            Name = name;
        }

        //Add a show to the list
        public void AddShow(Show show) {
            shows.Add(show);
        }

        //Print all shows
        public void PrintShows()
        {
            int i = 1;
            foreach (Show show in shows)
            {
                Console.Write($"{i++} ");
                Console.WriteLine(show);
            }
        }

        //Print all shows that are showing at certain time
        public void PrintShows(Time time)
        {
            int i = 1;
            foreach (Show show in shows)
            {                                
                if (show.Time == time)
                {
                    Console.Write($"{i++} ");
                    Console.WriteLine(show);
                }                
            }
        }

        //Printing all shows that belongs into this genre(s)
        public void PrintShows(Genre genre)
        {
            int i = 1;
            foreach (Show show in shows)
            {
                if (show.Movie.Genre.HasFlag(genre))
                {
                    Console.Write($"{i++} ");
                    Console.WriteLine(show);
                }
            }
        }

        //Print all shows that are showing on certain Day
        public void PrintShows(Day day)
        {
            int i = 1;
            foreach (Show show in shows)
            {
                if (show.Day == day)
                {
                    Console.Write($"{i++} ");
                    Console.WriteLine(show);
                }
            }
        }

        //Print all show that cast a certain actor/actress
        public void PrintShows(string actor)
        {
            int i = 1;
            foreach (Show show in shows)
            {                
                if (show.Movie.Cast.Count != 0 
                    && show.Movie.Cast.Contains(actor))
                {
                    Console.Write($"{i++} ");
                    Console.WriteLine(show);
                }
            }
        }

        //Print all shows that are showing at certain day and certain time
        public void PrintShows(Day day, Time time)
        {
            int i = 1;
            foreach (Show show in shows)
            {
                if (show.Day == day && show.Time == time)
                {
                    Console.Write($"{i++} ");
                    Console.WriteLine(show);
                }
            }
        }
    }
}

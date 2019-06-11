using System;
using System.Collections.Generic;

namespace COMP123_Assignment03
{

    /*
     * Show Enum with Flags
     *  None, Action, Romance, Documentary, Adult, Sci_Fi, Religious
     */
    [Flags]
    enum Genre
    {
        None = 0,
        Action = 1,
        Romance = 2,
        Documentary = 4,
        //From Henry's Mind
        Adult = 8,
        Sci_Fi = 16,
        Religious = 32,
        Comedy = 64,
        Horror = 128,
        Fantasy = 256,
        Adventure = 512,
        Animation = 1024
    }

    class Movie
    {
        //Get Length of the movie in minutes
        public int Length { get; }
        //Get the Year it was made in
        public int Year { get; }
        public string Title { get; }
        //TODO: It should be public get because genre can not be set in Set Genre later
        public Genre Genre { get; private set; }
        //Create Cast List
        public List<string> Cast { get; } = new List<string>();

        //Movie constructor
        public Movie(string title, int year, int length)
        {
            Title = title;
            Year = year;
            Length = length;
        }

        //Add an actor to the list
        public void AddActor(string actor)
        {
            Cast.Add(actor);
        }
        //|= or bits operator add bits to genre since genre enum has flags
        public void SetGenre(Genre genre)
        {
            Genre |= genre;
        }

        //To String OVeride Display title and actors
        public override string ToString()
        {
            string result = $"{Title}";

            if (Cast.Count != 0)
            {
                result += " - ";
                foreach (string actor in Cast)
                {
                    result += actor + " ";
                }
            }
            return result;
        }
    }
}

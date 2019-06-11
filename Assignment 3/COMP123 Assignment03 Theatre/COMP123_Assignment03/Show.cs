using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP123_Assignment03
{
    //Day Enum
    enum Day
    {
        Mon,
        Tue,
        Wed,
        Thu,
        Fri,
        Sat,
        Sun,
    }


    class Show
    {
        //Property Fields
        public double Price { get; }        
        public Day Day { get; }
        public Movie Movie { get; }
        public Time Time { get; }

        //Show Constructor
        public Show(Movie movie, Day day, double price, Time time) {
            Price   = price;
            Day     = day;
            Movie   = movie; //TODO: should check it linked with the previous object or not
            Time    = time;
        }

        //String override
        public override string ToString()
        {
            return $"Show: {Movie.Title} - Day: {Day} -Time: {Time} - Ticket Price: {Price}"; 
        }
    }
}

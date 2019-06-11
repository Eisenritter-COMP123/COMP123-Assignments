/************************************************************
 *  This code is created by:                                *
 *      |NAME|                              |Student ID|    *
 *      Tran Huy Hoang (Henry)      -       300979272       *
 *      Qian Long Zhou (George)     -       300613283       *
 *      Rafael Aguiar               -       301041266       *
 *      Ozgun Ceci                  -       301037034       *
 ************************************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP123_Assignment03
{
    class Program
    {
        static void Main(string[] args)
        {
            Movie terminator = new Movie("Terminator 2: Judgement Day", 1991, 105);
            terminator.AddActor("Arnold Schwarzenegger");
            terminator.SetGenre(Genre.Horror | Genre.Action);
            terminator.AddActor("Linda Hamilton");
            Show s1 = new Show(terminator, Day.Mon, 5.95, new Time(11, 35, 0));

            Console.WriteLine(s1);              //displays one object
            Theatre eglinton = new Theatre("Cineplex");
            eglinton.AddShow(s1);
            eglinton.PrintShows();              //displays one object

            Movie godzilla = new Movie("Godzilla 2014", 2014, 123);
            godzilla.AddActor("Aaron Johnson");
            godzilla.AddActor("Ken Watanabe");
            godzilla.AddActor("Elizabeth Olsen");
            godzilla.SetGenre(Genre.Action | Genre.Documentary | Genre.Comedy);

            Movie trancendence = new Movie("Transendence", 2014, 120);
            trancendence.AddActor("Johnny Depp");
            trancendence.AddActor("Morgan Freeman");
            trancendence.SetGenre(Genre.Comedy);
            eglinton.AddShow(new Show(trancendence, Day.Sun, 7.87, new Time(18, 5, 0)));

            Movie m1 = new Movie("The Shawshank Redemption", 1994, 120);
            m1.AddActor("Tim Robbins");
            m1.AddActor("Morgan Freeman");
            m1.SetGenre(Genre.Action);
            eglinton.AddShow(new Show(m1, Day.Sun, 8.87, new Time(14, 5, 0)));

            Movie avengers = new Movie("Avengers: Endgame", 2019, 120);
            avengers.AddActor("Robert Downey Jr.");
            avengers.AddActor("Chris Evans");
            avengers.AddActor("Chris Hemsworth");
            avengers.AddActor("Scarlett Johansson");
            avengers.AddActor("Mark Ruffalo");
            avengers.SetGenre(Genre.Action | Genre.Fantasy | Genre.Adventure);
            eglinton.AddShow(new Show(avengers, Day.Sat, 12.25, new Time(21, 5, 0)));

            m1 = new Movie("Olympus Has Fallen", 2013, 120);
            m1.AddActor("Gerard Butler");
            m1.AddActor("Morgan Freeman");
            m1.SetGenre(Genre.Action);
            eglinton.AddShow(new Show(m1, Day.Sun, 8.87, new Time(16, 5, 0)));

            m1 = new Movie("The Mask of Zorro", 1998, 136);
            m1.AddActor("Antonio Banderas");
            m1.AddActor("Anthony Hopkins");
            m1.AddActor(" Catherine Zeta-Jones");
            m1.SetGenre(Genre.Action | Genre.Romance);
            eglinton.AddShow(new Show(m1, Day.Sun, 8.87, new Time(16, 5, 0)));

            m1 = new Movie("Four Weddings and a Funeral", 1994, 117);
            m1.AddActor("Hugh Grant");
            m1.AddActor("Andie MacDowell");
            m1.AddActor("Kristin Scott Thomas");
            m1.SetGenre(Genre.Comedy | Genre.Romance);
            eglinton.AddShow(new Show(m1, Day.Sat, 8.87, new Time(15, 5, 0)));
            eglinton.AddShow(new Show(m1, Day.Tue, 6.50, new Time(16, 5, 0)));

            m1 = new Movie("You've Got Mail", 1998, 119);
            m1.AddActor("Tom Hanks");
            m1.AddActor("Meg Ryan");
            m1.SetGenre(Genre.Comedy | Genre.Romance);
            eglinton.AddShow(new Show(m1, Day.Sat, 8.87, new Time(15, 5, 0)));

            m1 = new Movie("The Poison Rose", 2019, 98);
            m1.AddActor("John Travolta");
            m1.AddActor("Morgan Freeman");
            m1.AddActor("Brendan Fraser");
            m1.SetGenre(Genre.Action | Genre.Romance);
            eglinton.AddShow(new Show(m1, Day.Sun, 10.25, new Time(22, 5, 0)));

            Movie car3 = new Movie("Cars 3", 2017, 109);
            car3.AddActor("Owen Williams");
            car3.AddActor("Cristela Alonzo");
            car3.AddActor("Arnie Hammer");
            car3.AddActor("Chris Cooper");
            car3.SetGenre(Genre.Comedy | Genre.Animation | Genre.Romance);
            eglinton.AddShow(new Show(car3, Day.Sat, 6.40, new Time(09, 55, 0)));
            eglinton.AddShow(new Show(car3, Day.Sat, 6.50, new Time(11, 05, 0)));

            Movie toys4 = new Movie("Toys Story 4", 2019, 89);
            toys4.AddActor("Keanu Reeves");
            toys4.AddActor("Christina Hendricks");
            toys4.AddActor("Tom Hanks");
            toys4.AddActor("Tim Allen");
            toys4.SetGenre(Genre.Comedy | Genre.Fantasy | Genre.Animation);
            eglinton.AddShow(new Show(toys4, Day.Sat, 6.40, new Time(14, 10)));

            eglinton.AddShow(new Show(godzilla, Day.Mon, 6.89, new Time(13, 55, 0)));
            eglinton.AddShow(new Show(avengers, Day.Sat, 12.25, new Time(21, 5, 0)));
            eglinton.AddShow(new Show(godzilla, Day.Sun, 6.89, new Time(14, 0)));
            eglinton.AddShow(new Show(toys4, Day.Sat, 6.40, new Time(14, 10)));
            eglinton.AddShow(new Show(avengers, Day.Sat, 12.25, new Time(21, 5, 0)));
            eglinton.AddShow(new Show(godzilla, Day.Sun, 6.89, new Time(16, 55, 0)));
            eglinton.AddShow(new Show(avengers, Day.Sat, 12.25, new Time(21, 5, 0)));
            eglinton.AddShow(new Show(m1, Day.Sat, 10.25, new Time(20, 35, 0)));
            eglinton.AddShow(new Show(godzilla, Day.Wed, 8.50, new Time(22, 5)));
            eglinton.AddShow(new Show(avengers, Day.Tue, 10.75, new Time(20, 30)));
            eglinton.AddShow(new Show(godzilla, Day.Thu, 8.50, new Time(20, 15)));
            eglinton.AddShow(new Show(avengers, Day.Wed, 10.75, new Time(20, 30)));
            eglinton.AddShow(new Show(godzilla, Day.Fri, 8.50, new Time(18, 25)));
            eglinton.AddShow(new Show(avengers, Day.Sun, 10.75, new Time(14, 15)));


            Console.WriteLine("\nPrint all shows");
            eglinton.PrintShows();                              //displays 27 objects

            Console.WriteLine("\nPrint all shows on Sunday");
            eglinton.PrintShows(Day.Sun);                       //displays 8 objects

            Console.WriteLine("\nPrint all action shows");
            eglinton.PrintShows(Genre.Action);                  //displays 19 objects

            Console.WriteLine("\nPrint all romance shows");
            eglinton.PrintShows(Genre.Romance);                 //displays 8 objects

            Console.WriteLine("\nPrint all action and romance shows");
            eglinton.PrintShows(Genre.Action | Genre.Romance);  //displays 3 objects

            Console.WriteLine("\nPrint all shows which actor is Morgan Freeman");
            eglinton.PrintShows("Morgan Freeman");              //displays 5 objects

            Time time = new Time(14, 05, 0);
            Console.WriteLine("\nPrint all shows which equals to 14:05");
            eglinton.PrintShows(time);                          //displays 6 objects


            Console.WriteLine("\nPrint all shows on Sunday and equals to 14:05");
            eglinton.PrintShows(Day.Sun, time);                 //displays 3 objects

            Console.ReadLine();
        }
    }
}

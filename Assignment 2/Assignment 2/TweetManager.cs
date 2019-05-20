using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Assignment_2
{
    class TweetManager
    {
        private static List<Tweet> TWEETS = new List<Tweet>();
        //private static string FILENAME = "";

        //static TweetManager()
        //{
        //    TextReader reader = new StreamReader(FILENAME);
        //    string line = "";
        //    while ((line = reader.ReadLine()) != null) { 
        //        TWEETS.Add(Tweet.Parse(line));
        //    }
        //    reader.Close();        
        //}
        public static void Initialize()
        {
            Tweet t1 = new Tweet("Raptors", "Obama", "Drake","Go Raptors!Go!","10001");
            Tweet t2 = new Tweet("Raptors", "Obama", "Drake", "Go Raptors!Go!", "10001");
            Tweet t3 = new Tweet("Raptors", "Obama", "Drake", "Go Raptors!Go!", "10001");
            Tweet t4 = new Tweet("Raptors", "Obama", "Drake", "Go Raptors!Go!", "10001");
            Tweet t5 = new Tweet("Raptors", "Obama", "Drake", "Go Raptors!Go!", "10001");
            TWEETS.Add(t1);
            TWEETS.Add(t2);
            TWEETS.Add(t3);
            TWEETS.Add(t4);
            TWEETS.Add(t5);

        }

        public static void ShowAll()
        {
            foreach (Tweet tweet in TWEETS){
                Console.WriteLine(tweet.Id);
                Console.WriteLine($"FROM {tweet.From,20}, TO {tweet.To,20}");
                Console.WriteLine(tweet.Body);
                Console.WriteLine(tweet.Tag);
            }
        }

        public static void ShowAll(string tag)
        {
            foreach (Tweet tweet in TWEETS)
            {
                if (tweet.Tag.Equals(tag))
                { 
                Console.WriteLine(tweet.Id);
                Console.WriteLine($"FROM {tweet.From,20}, TO {tweet.To,20}");
                Console.WriteLine(tweet.Body);
                Console.WriteLine(tweet.Tag);
                }
            }
        }
    }
}
